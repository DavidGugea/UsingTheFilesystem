using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test1
{
    class ReadWriteBinary
    {
        byte[] bytes = File.ReadAllBytes("photo.jpg");
        File.WriteAllBytes("photo2.jpg", bytes);
    }
}
