using System;
using System.IO;

namespace Product.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquivo arq = new LerArquivo();
            Products list;
            try
            {
                list = arq.GetArquivo();
                list.getAvarage();
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}
