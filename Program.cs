using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRecursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("ingrese nro. base: ");
            int numBase = int.Parse(Console.ReadLine());

            Console.Write("ingrese exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            Console.WriteLine(" la potencia de base con exponente es: " + Potencia(numBase, exponente));

            //---------------------------

            Console.WriteLine("Ingrese nro. para calcular factorial: ");
            var fact = int.Parse(Console.ReadLine());

            Console.WriteLine("el facrorial del nùmero es: " + Factorial(fact));
            */

            Console.Write("Ingrese un texto: ");
            string texto = Console.ReadLine();

            Console.WriteLine("el texto es palindromo: " + EsPalindromo(texto));
            Console.ReadKey();
        }

        private static int Potencia(int numBase, int exponente)
        {
            // condicion de finalizacion
            if (exponente == 1)
            {
                return numBase;
            }
            else
            {
                return numBase * Potencia(numBase, exponente - 1);
            }
        }

        private static int Factorial(int numero)
        {
            if (numero == 1)
                return 1;
            else
                return numero * Factorial(numero - 1);
        }

        private static bool EsPalindromo(string texto)
        {
            if (texto.Length == 0 || texto.Length == 1)
                return true;
            else
            {
                char ini, fin;
                ini = texto[0];                 // primer caracter  
                fin = texto[texto.Length - 1];  // último caracter

                if (ini == fin)
                {
                    string txt2 = texto.Substring(1, texto.Length - 2);  // extrae la subcadena interior
                    return EsPalindromo(txt2);
                }
                else 
                    return false;
            }
        }

    }
}
