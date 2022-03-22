using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serializing
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime BirthDate { get; set; }

        // initialize Record-Object
        public void Save(string path)
        {
            using(FileStream fileOutput = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binFttr = new BinaryFormatter();
                binFttr.Serialize(fileOutput, this);
            }
        }
    }
}
