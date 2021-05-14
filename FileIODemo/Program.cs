using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
             // FileExists();
             // ReadAllLines();   //exception
             // FileCopy();
             // ReadAllText();
             // DeleteFile();
             // ReadFromStreamReader();
             // WriteUsingStreamReader();
               Console.ReadKey();
        }
        static string path = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\Example.txt";
        public static void FileExists()
        {
            try
            {
                if (File.Exists(path))
                    Console.WriteLine("File Exist");
                else
                    Console.WriteLine("File doesn't exist");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public static void ReadAllLines()
        {
            try
            {
                string[] lines;
                if (File.Exists(path))
                {
                    lines = File.ReadAllLines(path);
                    Console.WriteLine(lines[0]);
                    Console.WriteLine(lines[1]);
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void ReadAllText()
        {
            try
            {
                string lines;
                if (File.Exists(path))
                {
                    lines = File.ReadAllText(path);
                    Console.WriteLine(lines);
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void FileCopy()
        {
            try
            {
                string copypath = @"C:\Users\prash\source\repos\FileIODemo\FileIODemo\ExampleNew.txt";
                if (File.Exists(path))
                {
                    File.Copy(path, copypath);
                    Console.WriteLine("Filed Copy Successfully");
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void DeleteFile()
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void ReadFromStreamReader()
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        String s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void WriteUsingStreamReader()
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        sr.WriteLine(".net vs Java");
                        sr.Close();
                        Console.WriteLine(File.ReadAllText(path));
                    }
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
