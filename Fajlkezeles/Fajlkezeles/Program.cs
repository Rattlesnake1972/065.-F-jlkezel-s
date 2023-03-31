using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fájl beolvasás:

            StreamReader sr = new StreamReader("elso.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                int szam =Convert.ToInt32( sr.ReadLine());
                Console.WriteLine(szam);
            }

            sr.Close();

            // Fájlírás:

            StreamWriter sw = new StreamWriter("mentes.txt",true,encoding:Encoding.UTF8);

            sw.WriteLine("Szasz Pisti!");
            sw.WriteLine("Hogy vagy?");
            sw.WriteLine("Érdekes fejlemények.");

            sw.Close();

            Console.ReadLine();
        }
    }
}
