using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;

namespace Product.Entities
{


    class LerArquivo
    {
        string Path = @"C:\Users\jonatas.santos\Desktop\Teste3\Product\Products.txt";
        Products list = new Products();
        public Products GetArquivo()
        {
            try
            {
                using (StreamReader sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        Double value = Double.Parse(line[1] , CultureInfo.InvariantCulture );
                        list.AddProduct(new Product(name, value));

                    }
                    return list;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return null;
        }
    }
}

