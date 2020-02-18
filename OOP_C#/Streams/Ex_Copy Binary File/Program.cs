using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Ex_Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";

            using (FileStream streamReader = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream streamWriter = new FileStream(picCopyPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArrey = new byte[4096];
                        var size = streamReader.Read(byteArrey, 0, byteArrey.Length);

                        if (size == 0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArrey, 0, size);
                    }
                }
            }
        }
    }
}
