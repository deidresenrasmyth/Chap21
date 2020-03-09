using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Chapt_21_pag619
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                FileStream aFile = new FileStream("Long.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                line = sr.ReadLine();
                //read date in line by line.
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been throw!");
                Console.WriteLine(e.ToString());
                return;
            }
            Console.ReadKey();
        }
        }
    }

