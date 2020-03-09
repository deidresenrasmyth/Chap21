using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chap_21_pag_617
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream aFile = new FileStream("Long.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(aFile);
                bool truth = true;
                //Write data to file.
                sw.WriteLine("Hello to you");
                sw.WriteLine("It is now {0} and thing are looking good.",
                    DateTime.Now.ToLongDateString());
                sw.Write("More than that,");
                sw.Write("it's {0} than C# is fun.", truth);
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
        }
    }
}

    

