using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int x, y;
            do
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CONVERTIR\n\n1) Programa que convierte un carácter ASCII a su equivalente numérico\n2) Programa que convierte de decimal a binario\n");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresa un carácter (ESC para terminar)");
                        do
                        {
                            ConsoleKeyInfo convertir = Console.ReadKey();

                            y = Convert.ToInt32(convertir.KeyChar);
                            Console.WriteLine($" = {y}");

                            if (convertir.KeyChar == 27)
                            {
                                break;
                            }
                        } while (true);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresa un número (Escribir no numéricos para terminar)");
                        do
                        {
                            string convertir = Console.ReadLine();
                            try
                            {
                                y = int.Parse(convertir);
                                string binario = Convert.ToString(y, 2).PadLeft(4, '0');
                                Console.WriteLine($"{convertir} = {binario}");
                            }
                            catch (Exception)
                            {
                                break;
                            }


                            if (convertir == "exit")
                            {
                                break;
                            }
                        } while (true);
                        break;
                }

                Console.Write("\n¿Desea repetir el programa? (y/n) ");
                n = Console.ReadLine();
            } while (n != "n");
        }   
    }
}
