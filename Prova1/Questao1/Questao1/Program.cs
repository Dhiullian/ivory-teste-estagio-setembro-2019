using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;            

            for (int i = numero - 1 ; i > 1; i--)
            {               
                    numero *= i;                                
            }

            Console.WriteLine("Resultado: {0}", numero);
            Console.ReadKey();
        }
    }

}
