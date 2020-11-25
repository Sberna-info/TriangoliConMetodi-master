using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangoli
{
    public class MetodiTriangoli
    {
        public static double Lato()
        {
            Console.Write($"Inserisci un lato del triangolo:");
            double lato = double.Parse(Console.ReadLine());
            return lato;
        }

        public static string OutputTrangolo(double l1, double l2, double l3)
        {
            string triangolo = null;
            if (l1 > 0 && l2 > 0 && l3 > 0)
            {
                if (l1 == l2 && l1 == l3)
                {
                    triangolo = "equilatero";
                }
                else if (l1 == l2 || l1 == l3 || l2 == l3)
                {
                    triangolo = "isoscele";
                }
                else
                {
                    triangolo = "scaleno";
                }
                Console.WriteLine($"Il triangolo in questione è {triangolo}");
            }
            else
            {
                Console.WriteLine("uno o più lati non sono validi");
            }
            return triangolo;
        }

        public static double? Perimetro(double l1, double l2, double l3)
        {
            double? perimetro = null;
            if(l1 < 0 || l2 < 0 || l3 < 0)
            {
                Console.WriteLine("Uno o piu lati non sono validi");
                return perimetro;
            }
            else
            {
                perimetro = l1 + l2 + l3;
                Console.WriteLine($"Il perimitro è {perimetro}");
                return perimetro;
            }

            
        }
    }
}
