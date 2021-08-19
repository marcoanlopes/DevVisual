using System;
using System.Collections.Generic;


namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Console.WriteLine("Digite a opção do exercicio desejada: ");
            // int escolha = Convert.ToInt32(Console.ReadLine());
            // switch (escolha)
            // {
            //     case 1:
            //         calculaArea();
            //         break;
            //     case 2:
            //         conversorDeMoeda();
            //         break;
            //     case 3:
            //         verficadorDeNumero();
            //         break;
            //     case 4:
            //         checadorDeIdade();
            //         break;
            //     case 5:
            //         geraFibonacci();
            //         break;
            //     case 6:
            //         funcSort();
            //         break;
            //     default:
            //         Console.WriteLine("Opção invalida!");
            //         break;
            // }

            // area = altura * largura;
            // Console.WriteLine("Digite seu nome");
            // string name = Console.ReadLine();
            // Console.WriteLine("Digite sua idade");
            // int idade = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(name);
            // Console.WriteLine($"Nome: { name } e idade { idade }");

        }

        static void calculaArea()
        {
            Console.WriteLine("Digite a Altura e depois a Largura do retângulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            int largura = Convert.ToInt32(Console.ReadLine());
            int area = altura * largura;
            Console.WriteLine("A área do retangulo é: " + area);
        }

        static void conversorDeMoeda()
        {
            Console.WriteLine("Digite o valor em real para converter (R$)");
            double real = Convert.ToDouble(Console.ReadLine());
            double dolar = real / 5.17;
            double euro = real / 6.14;
            double peso = real / 0.05;
            Console.WriteLine($"O valor em dolar é: { dolar } | o valor em euro é: { euro } | o valor em peso é { peso }");
        }

        static void verficadorDeNumero()
        {
            Console.WriteLine("Digite dois valores e descubra qual o maior: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine($"{ n1 } é maior que o { n2 }");
            }
            else if (n1 < n2)
            {
                Console.WriteLine($"{ n2 } é maior que o { n1 }");
            }
            else
            {
                Console.WriteLine($"Os números { n1 } e { n2 } são iguais");
            }
        }

        static void checadorDeIdade()
        {
            Console.WriteLine("Digite a idade para saber em qual grupo se qualifica: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade <= 13)
            {
                Console.WriteLine("Idade de criança!");
            }
            else if (idade > 13 || idade <= 18)
            {
                Console.WriteLine("Idade de adolescente!");
            }
            else if (idade > 18 || idade <= 60)
            {
                Console.WriteLine("Idade de adulto!");
            }
            else
            {
                Console.WriteLine("Idade de idoso!");
            }
        }

        static void geraFibonacci()
        {
            Console.WriteLine("Digite um número para saber a sequência Fibonacci até ele: ");
            int fib = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int y = 1;
            int z = 1;
            // List<Int32> fibo = new List<Int32>();
            do
            {
                if (x == 0 && fib > 1)
                {
                    Console.Write(x + ", ");
                    x = x + 1;
                    Console.Write(x);
                }
                else if (fib > 1)
                {
                    Console.Write(", " + z);
                    z = x + y;
                    x = y;
                    y = z;
                    // fibo.Add(z);
                }
                else if (fib == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("0, 1");
                }
            } while (z < fib);
        }
        static void funcSort()
        {
            Random rnd = new Random();

            int[] vetorDaDerrota = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                vetorDaDerrota[i] = rnd.Next(0, 101);
            }

            //int aux;
            int listaSize = vetorDaDerrota.Length;
            // Boolean trocado = false;

            //SORT MANUAL
            // for (int k = 0; k < listaSize; k++)
            // {
            //     for (int l = 0; l < listaSize; l++)
            //     {
            //         if (l < 9)
            //         {
            //             if (vetorDaDerrota[l] > vetorDaDerrota[(l + 1)])
            //             {
            //                 aux = vetorDaDerrota[l];
            //                 vetorDaDerrota[l] = vetorDaDerrota[(l + 1)];
            //                 vetorDaDerrota[(l + 1)] = aux;

            //             }
            //         }
            //     }
            // }
            // foreach (var j in vetorDaDerrota)
            // {
            //     Console.WriteLine(j);
            // }

            // Sort automático funcionando \/
            Array.Sort(vetorDaDerrota);
            foreach (var numeroLista in vetorDaDerrota)
            {
                Console.Write(numeroLista + " ");
            }


        }

    }
}