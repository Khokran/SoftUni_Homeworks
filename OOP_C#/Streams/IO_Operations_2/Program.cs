using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace IO_Operations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes("Здрасти GZip!")))
            {
                using (FileStream fs = new FileStream("test.gz", FileMode.Create))
                {
                    using (GZipStream gz = new GZipStream(ms, CompressionLevel.Optimal))
                    {
                        ms.CopyTo(fs);
                    }
                }
            }
        }
    }
}
