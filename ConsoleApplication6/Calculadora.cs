using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            float div;
            int operacion;

            do
            {
                Console.WriteLine("Ingrese el primer número: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\n¿Que operación desea realizar? \n1. Suma \n2. Resta \n3. Multiplicación \n4. División \n5. Salir \n");

                operacion = int.Parse(Console.ReadLine());

                switch (operacion)
                {
                    case 1:
                        Console.WriteLine("\nSuma de " + numero1 + " y " + numero2 + " es " + (numero1 + numero2) + "\n");
                        break;
                    case 2:
                        Console.WriteLine("\nLa resta de " + numero1 + " y " + numero2 + " es " + (numero1 - numero2) + "\n");
                        break;
                    case 3:
                        Console.WriteLine("\nLa multiplicación de " + numero1 + " por " + numero2 + " es " + (numero1 * numero2) + "\n");
                        break;
                    case 4:
                        div = ((float)numero1) / ((float)numero2);
                        Console.WriteLine("\nLa división de " + numero1 + " por " + numero2 + " es " + div + "\n");
                        break;
                    case 5:
                        Console.WriteLine("\nGracias por usar la calculadora, adios.");
                        break;
                }
            } while (operacion != 5);
           
            Console.ReadKey();
        }
    }
}
