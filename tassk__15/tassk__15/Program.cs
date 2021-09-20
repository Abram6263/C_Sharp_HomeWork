using System;
using System.IO;
using System.IO.Compression;

namespace tassk__15
{
    class Program
    {
        static FileInfo marker = null;
        static FileInfo RekursiveSearch(DirectoryInfo directory, string fileName)
        {
            foreach(var file in directory.GetFiles())
            {
                if(fileName == file.Name)
                {
                    marker = file;
                    return file;
                }
            }

            foreach(var directory1 in directory.GetDirectories())
            {

                RekursiveSearch(directory1, fileName);
                if (marker != null)
                {
                    return marker;
                }
                
            }
            if(marker != null)
            {
                return marker;
            }
            else
            {
                return null;
            }
        }

        static void Main(string[] args)
        {
            string directoryPath;
            string fileName;
            Console.WriteLine("Введите путь к файлу: ");
            directoryPath = Console.ReadLine();
            var directory = new DirectoryInfo(directoryPath);
            Console.WriteLine("Введите имя файла: ");
            fileName = Console.ReadLine();
            try
            {
                var file = RekursiveSearch(directory, fileName);
                if (file == null)
                {
                    throw new Exception("Файл не найден!");
                }
                else
                {
                    string archiveDirectory = Path.Combine(file.DirectoryName, Path.GetFileNameWithoutExtension(file.Name) + ".zip");

                    using (var fileStream = new FileStream(archiveDirectory, FileMode.Create))
                    {
                        using (var zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create))
                        {
                            zipArchive.CreateEntryFromFile(file.FullName, file.Name);
                        }
                    }
                    Console.WriteLine(archiveDirectory);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
