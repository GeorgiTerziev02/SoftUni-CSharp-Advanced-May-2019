using System;
using System.IO;

namespace Problem_4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";

            using (var reader = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(picCopyPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];

                        int size = reader.Read(byteArray, 0, byteArray.Length);

                        if(size==0)
                        {
                            break;
                        }

                        writer.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}
