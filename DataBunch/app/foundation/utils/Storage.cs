using System.IO;
using DataBunch.app.foundation.exceptions;

namespace DataBunch.app.foundation.utils
{
    public static class Storage
    {
        public const string PATH = @"P:\Development\Projects\data_bunch\collections";

        public static DirectoryInfo copyDirectory(string originPath, string destinationPath)
        {
            if (!Directory.Exists(destinationPath)) {
                Directory.CreateDirectory(destinationPath);
            }

            if (Directory.Exists(destinationPath)) {
                Directory.Delete(destinationPath, true);
            }

            foreach (var dirPath in Directory.GetDirectories(originPath, "*", SearchOption.AllDirectories)) {
                Directory.CreateDirectory(dirPath.Replace(originPath, destinationPath));
            }

            foreach (var newPath in Directory.GetFiles(originPath, "*.*", SearchOption.AllDirectories)) {
                File.Copy(newPath, newPath.Replace(originPath, destinationPath), true);
            }

            return new DirectoryInfo(destinationPath);
        }

        public static DirectoryInfo createDirectory(string path, bool overwrite = true)
        {
            if (overwrite && Directory.Exists(path)) {
                Directory.Delete(path, true);
            }

            return Directory.CreateDirectory(path);
        }

        public static bool deleteDirectory(string path)
        {
            if (!Directory.Exists(path)) {
                return false;
            }

            Directory.Delete(path, true);
            return true;
        }

        public static void copyFile(string source, string destination)
        {
            if (!File.Exists(source)) {
                throw new StorageException("File does not exists.");
            }

            File.Copy(source, destination, true);
        }

        public static void deleteFile(string path)
        {
            if (!File.Exists(path)) {
                return;
            }

            File.Delete(path);
        }

        public static bool containsDifferentTypes(DirectoryInfo directory)
        {
            string type = null;

            foreach (var file in directory.GetFiles()) {
                if (type != null && type != file.Extension) {
                    return true;
                }

                type = file.Extension;
            }

            return false;
        }
    }
}
