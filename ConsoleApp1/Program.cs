using System;
using System.Transactions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {


            ////////ILGIS
            while (true) {
                double ilgis;
                double plotis;
                Console.WriteLine("Provide width: ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
                    {
                        ilgis = width;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, try again: ");
                    }
                }
                //////////////PLOTIS
                Console.WriteLine("Provide height: ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                    {
                        plotis = height;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, try again: ");
                    }

                }
                double area = ilgis * plotis;
                Console.WriteLine("Plotis yra:");
                Console.WriteLine();
                Console.WriteLine(area);
                //////////////////KAINA
                double mazaKaina = 1.99;
                double dideleKaina = 2.50;
                double isvada;

                if (area < 80)
                {
                    isvada = area * dideleKaina;
                }
                else
                {
                    isvada = area * mazaKaina;
                }
                Console.WriteLine("Tai kainuos: " + isvada + "$");
                Console.WriteLine();





                Console.WriteLine();
               
            }


            /*if (double.TryParse(Console.ReadLine(), out double width))
            {
                if (width>0)
                {
                    Console.WriteLine("Can't be zero");
                }

            }
            else
            {
                Console.WriteLine("Not a number, try again: ");
                
            }
            */
            // double plotis = width * 2;
            //Console.WriteLine(plotis);

        }
    }
}