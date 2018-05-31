using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila:");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);
            string tiedosto = "D:\\Lämpötila.txt";
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("uusi lämpötila tallennettu");
            Console.ReadLine();
        }
    }
}
