using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileExists();
            // ReadAllLines();
          //  FileCopy();
            //ReadAllText();
            //DeleteFile();
           // ReadFromStreamReader();
            WriteUsingStreamReader();

            Console.ReadKey();

        }
        public static void FileExists()
        {
            String path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\Example.txt";
            if (File.Exists(path))            
                Console.WriteLine("File Exist");            
            else
                Console.WriteLine("File doesn't exist");
        }
        public static void ReadAllLines()
        {
            String path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\Example.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }
        public static void ReadAllText()
        {

            String path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }
        public static void FileCopy()
        {
            String path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\Example.txt";
            String copypath = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\ExampleNew.txt";
            File.Copy(path, copypath);

        }
        public static void DeleteFile()
        {
            String path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\ExampleNew.txt";
            File.Delete(path);
        }
        public static void ReadFromStreamReader()
        {
            String path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\Example.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamReader()
        {
            String path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\Example1.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World - .Net is Awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }

        }

    }
}
