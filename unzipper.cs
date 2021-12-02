using System.IO.Compression;

namespace unzipper
{
    public class unzipper
    {
        public static void Main()
        {
            goDeeper();
            Console.Clear();
            Console.WriteLine("Das Programm ist nun fertig.");
        }

        public static void goDeeper()
        {
            //Enter here a path to a folder containing only the "Geschenk.zip" file e.g. "C:/user/user/desktop/new_folder/". !!!enter a '/' at the End!!! 
            string filePath = "";
            DirectoryInfo dir = new DirectoryInfo(filePath); //create a directory to or file

            foreach (FileInfo fi in dir.GetFiles()) //foreach file in dir
            {
                if (fi.Name.Contains(".zip")) //if file contains ".zip"
                {
                    ZipFile.ExtractToDirectory(filePath + fi.Name, filePath); //ectract the file to or folder 
                    File.Delete(filePath + fi.Name); //delete the old file (in case ther are Duplicate names)
                    goDeeper(); //call goDeeper recusive
                }
            }
        }
    }
}