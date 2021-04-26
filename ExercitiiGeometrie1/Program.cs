using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercitiiGeometrie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program arata exercitii geometrice");
            EcuatiaSiDistanta();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Coliniaritate();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Concurente();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            ProdusScalar();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            ProdusVectorial();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            ProdusMixt();
            Console.ReadKey();
        }
        private static void EcuatiaSiDistanta()
        {
            try
            {
                Console.WriteLine("1.Aratam ecuatia si distanta");
                double xA, yA, xB, yB;
                Console.WriteLine("Coordonatele lui A:");
                xA = double.Parse(Console.ReadLine());
                yA = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele lui B:");
                xB = double.Parse(Console.ReadLine());
                yB = double.Parse(Console.ReadLine());
                double X = yA - yB;
                double Y = xB - xA;
                double Z = xA * yB - xB * yA;
                string semnY = " - ";
                string semnZ = " - ";
                double dist = Math.Sqrt(Y * Y + X * X);
                if (Y < 0)
                {
                    Y = -Y;
                    semnY = " + ";
                }
                if (Z > 0)
                {
                    semnZ = " + ";
                }
                else
                {
                    Z = -Z;
                }
                string solution = $"Ecuatia:{X}x {semnY}{Y}y {semnZ}{Z} = 0";
                Console.WriteLine(solution);
                Console.Write("Distanta este: ");
                Console.WriteLine(dist);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Coliniaritate()
        {
            try
            {
                Console.WriteLine("2.Studiem coliniaritatea");
                double xA, yA, xB, yB, xC, yC, Det;
                Console.WriteLine("Coordonatele lui A:");
                xA = double.Parse(Console.ReadLine());
                yA = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele lui B:");
                xB = double.Parse(Console.ReadLine());
                yB = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele lui C:");
                xC = double.Parse(Console.ReadLine());
                yC = double.Parse(Console.ReadLine());
                Det = xA * yB + xB * yC + xC * yA - yB * xC - xA * yC - xB * yA;
                if (Det == 0)
                    Console.WriteLine("Punctele sunt coliniare");
                else
                    Console.WriteLine("Punctele nu sunt coliniare");
                Console.WriteLine("Determinantul este: " + Det);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Concurente()
        {
            try
            {
                Console.WriteLine("3.Examinam daca dreptele sunt concurente");
                double a1, a2, a3, b1, b2, b3, c1, c2, c3;
                Console.WriteLine("Coordonatele primei drepte:");
                a1 = double.Parse(Console.ReadLine());
                b1 = double.Parse(Console.ReadLine());
                c1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele la dreapta a doua:");
                a2 = double.Parse(Console.ReadLine());
                b2 = double.Parse(Console.ReadLine());
                c2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele la dreapta a treia:");
                a3 = double.Parse(Console.ReadLine());
                b3 = double.Parse(Console.ReadLine());
                c3 = double.Parse(Console.ReadLine());
                Console.WriteLine($"D1:{a1}x + {b1}y + {c1} = 0");
                Console.WriteLine($"D2:{a2}x + {b2}y + {c2} = 0");
                Console.WriteLine($"D3:{a3}x + {b3}y + {c3} = 0");
                if (a1 * b2 * c3 + a2 * b3 * c1 + b1 * c2 * a3 - c1 * b2 * a3 - b3 * c2 * a1 - b1 * a2 * c3 == 0)
                    Console.WriteLine("Dreptele sunt concurente");
                else
                    Console.WriteLine("Dreptele nu sunt concurente");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void ProdusScalar()
        {
            try
            {
                Console.WriteLine("4.Studiem produsul scalar");
                double x1, y1, z1, x2, y2, z2;
                Console.WriteLine("Coordonatele primului vector:");
                x1 = double.Parse(Console.ReadLine());
                y1 = double.Parse(Console.ReadLine());
                z1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele la al doilea vector:");
                x2 = double.Parse(Console.ReadLine());
                y2 = double.Parse(Console.ReadLine());
                z2 = double.Parse(Console.ReadLine());
                if (x1 < 0)
                {
                    Console.Write($"V1 = -{-x1}i");
                }
                else if (x1 > 0)
                {
                    Console.Write($"V1 = +{x1}i");
                }
                if (y1 < 0)
                {
                    Console.Write($" - {-y1}j");
                }
                else if (y1 > 0)
                {
                    Console.Write($" + {y1}j");
                }
                if (z1 < 0)
                {
                    Console.WriteLine($" - {-z1}k");
                }
                else if (z1 > 0)
                {
                    Console.WriteLine($" + {z1}k");
                }
                if (x2 < 0)
                {
                    Console.Write($"V2 = -{-x2}i");
                }
                else if (x2 > 0)
                {
                    Console.Write($"V2 = +{x2}i");
                }
                if (y2 < 0)
                {
                    Console.Write($" - {-y2}j");
                }
                else if (y2 > 0)
                {
                    Console.Write($" + {y2}j");
                }
                if (z2 < 0)
                {
                    Console.WriteLine($" - {-z2}k");
                }
                else if (z2 > 0)
                {
                    Console.WriteLine($" + {z2}k");
                }
                double ProdusScal = x1 * x2 + y1 * y2 + z1 * z2;
                if (ProdusScal == 0)
                {
                    Console.WriteLine("Este perpendicular");
                }
                else
                {
                    Console.WriteLine($"Produsul scalar = {ProdusScal},deci nu este perpendicular");
                }
                Console.WriteLine($"Marimea primului vector = {Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2))}");
                Console.WriteLine($"Marimea la al doilea vector = {Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2) + Math.Pow(z2, 2))}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void ProdusVectorial()
        {
            try
            {
                Console.WriteLine("5.Studiem produsul vectorial");
                double x1, y1, z1, x2, y2, z2, colin, det1, det2, det3;
                Console.WriteLine("Coordonatele primului vector:");
                x1 = double.Parse(Console.ReadLine());
                y1 = double.Parse(Console.ReadLine());
                z1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele la al doilea vector:");
                x2 = double.Parse(Console.ReadLine());
                y2 = double.Parse(Console.ReadLine());
                z2 = double.Parse(Console.ReadLine());
                det1 = (y1 * z2 - y2 * z1);
                det2 = (x2 * z1 - x1 * z2);
                det3 = (x1 * y2 - x2 * y1);
                if (det1 < 0)
                {
                    Console.Write($"VProdus = -{-det1}i");
                }
                else if (det1 > 0)
                {
                    Console.Write($"VProdus = +{det1}i");
                }
                if (det2 < 0)
                {
                    Console.Write($" - {-det2}j");
                }
                else if (det2 > 0)
                {
                    Console.Write($" + {det2}j");
                }
                if (det3 < 0)
                {
                    Console.WriteLine($" - {-det3}k");
                }
                else if (det3 > 0)
                {
                    Console.WriteLine($" + {det3}k");
                }
                colin = det1 + det2 + det3;
                if (colin == 0)
                {
                    Console.WriteLine("Vectorii sunt coliniari");
                }
                else
                {
                    Console.WriteLine("Vectorii nu sunt coliniari");
                }
                Console.WriteLine($"Marimea la VProdus = {Math.Sqrt(Math.Pow(det1, 2) + Math.Pow(det2, 2) + Math.Pow(det3, 2))}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void ProdusMixt()
        {
            try
            {
                Console.WriteLine("6.Studiem produsul mixt");
                double x1, y1, z1, x2, y2, z2, x3, y3, z3, prodmixt;
                Console.WriteLine("Coordonatele primului vector:");
                x1 = double.Parse(Console.ReadLine());
                y1 = double.Parse(Console.ReadLine());
                z1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele la al doilea vector:");
                x2 = double.Parse(Console.ReadLine());
                y2 = double.Parse(Console.ReadLine());
                z2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordonatele la al treilea vector:");
                x3 = double.Parse(Console.ReadLine());
                y3 = double.Parse(Console.ReadLine());
                z3 = double.Parse(Console.ReadLine());
                prodmixt = (x1 * y2 * z3) + (x2 * y3 * z1) + (x3 * y1 * z2) - (x3 * y2 * z1) - (x1 * y3 * z2) - (x2 * y1 * z3);
                Console.WriteLine($"Produsul mixt este:{prodmixt}");
                if (prodmixt == 0)
                {
                    Console.WriteLine("Sunt coplanari");
                }
                else
                {
                    Console.WriteLine("Nu sunt coplanari");
                }
                Console.WriteLine($"Volumul paralelipipedului este:{Math.Sqrt(Math.Pow(prodmixt, 2))}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
