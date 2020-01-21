using System;
using System.IO;

namespace example1
{
    class Test
    {
        static void Main(string[] args)
        {
            string qq;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                StreamReader sr = new StreamReader("TestFile.txt");
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    sr.Close();
                }

                StreamWriter arq = new StreamWriter("TestFile.txt");

                Console.Write("Escreva algo:");
                qq = Console.ReadLine();
                arq.WriteLine(qq);

                arq.Close();
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

           

            Console.ReadKey();
        }
    }
}