using System.IO;

namespace FileIO
{
    public class Cleaner
    {
        public static void CleanDirectory(string path)
        {
            string[] files = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);
            foreach(string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch(IOException) { }
            }
            foreach(string folder in folders)
            {
                try
                {
                    Directory.Delete(folder);
                }
                catch(IOException) { }
            }
        }

        public static void DeleteFile(string path, string fileName)
        {
            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
            {
                if(fileName.Equals(file))
                {
                    File.Delete(file);
                    break;
                }

            }
        }

    }
}
