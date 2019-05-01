using System;
using System.IO;
using System.IO.Compression;
using DataBunch.app.collection.models;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;
using File = DataBunch.app.file.models.File;

namespace DataBunch.app.collection.factories
{
    public static class CollectionFactory
    {
        public static Collection createFromDirectory(string path, string name)
        {
            if (!Auth.isLoggedIn()) {
                throw new AuthException("You must be logged in to create collection.");
            }

            var directory = copyDirectory(path);
            return initializeCollection(directory, name);
        }

        public static Collection createFromZip(string path, string name)
        {
            if (!Auth.isLoggedIn()) {
                throw new AuthException("You must be logged in to create collection.");
            }

            try {
                if (Directory.Exists(Storage.PATH + "/" + name)) {
                    Directory.Delete(Storage.PATH + "/" + name, true);
                }

                ZipFile.ExtractToDirectory(path, Storage.PATH + "/" + name);
            } catch (Exception exception) {
                throw new StorageException("Please provide valid zip archive." + exception.Message);
            }

            return initializeCollection(new DirectoryInfo(Storage.PATH + "/" + name), name);
        }

        public static void exportToZip(Collection collection, string destination, string name = null)
        {
            try {
                name = name ?? collection.Name;
                destination += "/" + name;

                ZipFile.CreateFromDirectory(collection.Path, destination + ".zip");
            } catch (Exception exception) {
                throw new StorageException(exception.Message);
            }
        }

        private static Collection initializeCollection(DirectoryInfo directory, string name = null)
        {
            if (Storage.containsDifferentTypes(directory)) {
                throw new StorageException("Collection can be initialized only from folder containing same file types\n" + directory.FullName);
            }

            var collection = new Collection(name ?? directory.Name, directory.FullName,Auth.getUser().ID, 0);

            foreach (var file in directory.GetFiles()) {
                collection.addFile(new File(file.FullName, file.Name, file.Extension.Substring(1)));
            }

            foreach (var subDir in directory.GetDirectories()) {
                collection.Children.Add(initializeCollection(subDir));
            }

            return collection;
        }

        private static DirectoryInfo copyDirectory(string path)
        {
            if (!Directory.Exists(path)) {
                throw new StorageException("Please provide real directory.");
            }

            return Storage.copyDirectory(path, path.Replace(path, Storage.PATH));
        }
    }
}
