using System;

namespace divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Numerador, Denominador, Resultado;

            Console.WriteLine("DIVISÃO");

            Console.WriteLine();

            Console.WriteLine("Digite o numerador da divisão:");
            Numerador = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o denominador da divisão:");
            Denominador = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Resultado = Numerador / Denominador;

            if (Denominador == 0){
            Console.WriteLine("Zero nao pode ser dividido");
            }
            else{

            Console.WriteLine($"O resultado é: {Resultado}");
            }
                        
        }
    }
}
