using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis de Entrada de dados.
            string nome;
            int tam_nome;

            // Entrada de dados do usuário.
            Console.Write("Informe o nome:");
            nome = Console.ReadLine();

            // Verificação do tamanho.
            tam_nome = nome.Length;

            Console.Clear();           

            // Chamada da função  para imprimir a matriz.
            Imprimir_Matriz(tam_nome, nome);

            Console.ReadKey();
        }

        // Função de Impressão da matriz com as informações recebidas.
        static void Imprimir_Matriz(int tam_nome,string nome)
        {
            // Variaveis para o preenchimento da matriz.
            int max_tam = ((tam_nome + 2) * 3) - tam_nome;
            int contador = 1;

            Console.WriteLine();

            for ( int i = 0; i < 3; i++)
            {
                for (int j = 0; j < tam_nome + 2; j++)
                {
                    // Condicional para preenchimento da primeira linha.
                    if ( i == 0)
                    {
                        // Condicional para alinhamento estetico.
                        if ( contador <= 9)
                        {
                            Console.Write($"[{contador.ToString("00")}]  ");
                        }
                        else
                        {
                            Console.Write($"[{contador}]  ");
                        }
                        
                        contador++;
                    }
                    // Condicional para inserção do ultimo valor da matriz na primeira posição da segunda linha.
                    else if( i == 1 && j == 0)
                    {
                        // Condicional para alinhamento estetico.
                        if (contador <= 9)
                        {
                            Console.Write($"[{max_tam.ToString("00")}]  ");
                        }
                        else
                        {
                            Console.Write($"[{max_tam}]  ");
                        }    
                        
                        max_tam--;
                    }
                    //Condicional para a inserção do da variavel nome na matriz.
                    else if (i == 1 && j > 0 && j < tam_nome + 1)
                    {
                        Console.Write($" {nome[j - 1]}    ");
                    }
                    // Condicional para inserção da variavel contador após o preenchimento do nome.
                    else if (i == 1 && j == tam_nome + 1)
                    {
                        if (contador <= 9)
                        {
                            Console.Write($"[{contador.ToString("00")}]  ");
                        }
                        else
                        {
                            Console.Write($"[{contador}]  ");
                        }                        
                    }  
                    // preenchimento do restante da matriz.
                    else
                    {
                        // Condicional para alinhamento estetico.
                        if (contador <= 9)
                        {
                            Console.Write($"[{max_tam.ToString("00")}]  ");
                        }
                        else
                        {
                            Console.Write($"[{max_tam}]  ");
                        }   
                        
                        max_tam--;
                    }                
                }
                Console.WriteLine("\n");
            }
        }
    }
}
