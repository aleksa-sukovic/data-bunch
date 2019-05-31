using DataBunch.app.collection.models;
using DataBunch.app.collection.repositories;
using DataBunch.app.file.models;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;

namespace DataBunch.app.collection.factories
{
    public static class CollectionMergeFactory
    {
        public static Collection merge(Collection first, Collection second, string name)
        {
            var result = createMergeCollection(first, second, name);

            result = joinFiles(result, first);
            result = joinFiles(result, second);

            foreach (var child in first.Children) {
                result = joinChildren(result, child);
            }

            foreach (var child in second.Children) {
                result = joinChildren(result, child);
            }

            Storage.deleteDirectory(first.Path);
            Storage.deleteDirectory(second.Path);

            return result;
        }

        private static Collection createMergeCollection(Collection first, Collection second, string name)
        {
            var collectionRepo = new CollectionRepository();
            first = collectionRepo.addIncludes(first);
            second = collectionRepo.addIncludes(second);

            var parentId = first.ParentID == second.ParentID ? first.ParentID : 0;
            var path = parentId != 0 ? first.Parent.Path + "/" + name : Storage.PATH + "/" + name;

            var collection = new Collection(name, path, Auth.getUser().ID, parentId, first.Type);
            Storage.createDirectory(collection.Path);

            return collection;
        }

        private static Collection joinFiles(Collection destination, Collection source)
        {
            foreach (var file in source.Files) {
                var newFile = new File(destination.Path + "/" + file.Name, file.Name, file.Type, destination.ID);

                Storage.copyFile(file.Path, newFile.Path);
                Storage.deleteFile(file.Path);

                destination.addFile(newFile);
            }

            return destination;
        }

        private static Collection joinChildren(Collection destination, Collection source)
        {
            Storage.createDirectory(destination.Path + "/" + source.Name);
            var newCollection = new Collection(source.ID, source.Name, destination.Path + "/" + source.Name, source.UserID, destination.ID, source.Type, source.CreatedAt, source.UpdatedAt);

            foreach (var file in source.Files) {
                var newFile = new File(newCollection.Path + "/" + file.Name, file.Name, file.Type, destination.ID);

                Storage.copyFile(file.Path, newFile.Path);

                newCollection.addFile(newFile);
            }

            foreach (var child in source.Children) {
                newCollection = joinChildren(newCollection, child);
            }

            destination.Children.Add(newCollection);
            Storage.deleteDirectory(source.Path);

            return destination;
        }
    }
}
