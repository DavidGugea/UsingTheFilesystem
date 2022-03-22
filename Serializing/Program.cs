using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializing
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static Person Load(string path)
        {
            using(FileStream fileInput = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binFttr = new BinaryFormatter();
                return (Person)binFttr.Deserialize(fileInput);
            }
        }
    }
}
