using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo myFile = new FileInfo("TextFile1.txt");
            FileStream myStream = myFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            /*
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                for(int i = 0; i < 11; i++)
                {
                    sw.Write($"Line : {i}");
                }
            }
            */
            string output = "";

            using (StreamReader reader = File.OpenText("TextFile1.txt"))
            {
                while((output = reader.ReadLine()) != null)
                {
                    Console.WriteLine(output);
                }
            }
            Console.ReadLine();
        }
    }
}
