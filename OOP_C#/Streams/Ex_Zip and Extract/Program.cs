using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Ex_Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipFile = @"..\..\..\myNewZip.zip";
            string file = "copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }
    }
}
