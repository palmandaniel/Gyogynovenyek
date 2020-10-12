using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Noveny> novenyek = new List<Noveny>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();

        static void NovenyBeolvas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                novenyek.Add(new Noveny(file.ReadLine()));
            }
            file.Close();

           
        }

        static void Feladat1()
        {
            Console.WriteLine("1. feladat: Növények száma: {0}", novenyek.Count);
        }

        static void Feladat2()
        {
            Console.WriteLine("\n2. Feladat:Gyűjthető részek:");

            for (int i = 0; i < novenyek.Count; i++)
            {
                if (!reszek.ContainsKey(novenyek[i].Resz))
                {
                    reszek.Add(novenyek[i].Resz, 0);
                }
            }

            foreach (var n in novenyek)
            {
                reszek[n.Resz]++;
            }


            foreach (var r in reszek)
            {
                Console.WriteLine($"{r.Key}:  {r.Value}");
            }
            
        }

        static void Feladat3()
        {
            int max = 0;
            for (int i = 0; i < novenyek.Count; i++)
            {
                if (novenyek[i].Idotartam>max)
                {
                    max = novenyek[i].Idotartam;
                }
            }
            Console.WriteLine("\n3. Feladat: Legtöbb idő amíg gyűjthető: {0}", max);
            Console.WriteLine("Növény(ek): ");
            for (int i = 0; i < novenyek.Count; i++)
            {
                if (novenyek[i].Idotartam==max)
                {
                    Console.WriteLine(novenyek[i].Nev);
                }
            }
        }

        static void Feladat4()
        {
            double sum = 0;

            for (int i = 0; i < novenyek.Count; i++)
            {
                sum += novenyek[i].Idotartam;
            }
            Console.WriteLine("\n4. Feladat: Átlag gyűjthető időtartam: {0}", sum/novenyek.Count);
        }

        static void Main(string[] args)
        {
            NovenyBeolvas();
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();

            Console.ReadKey();
        }
    }
}
