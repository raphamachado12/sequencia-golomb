using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace exercicios
{
    public class Exercicios
    {
        public static void Exercicio5()
        {
            Console.WriteLine("Digite o tamanho para mostrar os primeiros valores da sequência de Golomb:");

            int tamanho = int.Parse(Console.ReadLine());

            string resultado = "";

            for (int i = 1; i <= tamanho; i++)
            {
                var valor = FindGolomb(i);
                resultado += $"{valor}, ";
            }

            // Remove a última virgula do resultado
            resultado = resultado.Remove(resultado.Length - 2);

            Console.WriteLine($"Resultado: {resultado}");
        }

        static int FindGolomb(int n)
        {
            if (n == 1)
                return 1;

            return 1 + FindGolomb(n -
            FindGolomb(FindGolomb(n - 1)));
        }
    }
}
