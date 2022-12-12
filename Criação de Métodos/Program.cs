using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criação_de_Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {//Algorimo que dá 4 opções para escolher, cada uma delas executará uma função diferente!
            int op = 1;
            while (op != 0)

            {
                //O indivíduo optará por uma das 4 opções disponibilizadas!
                Console.WriteLine("Bem-vindo, escolha uma das opções a seguir");
               
                //Primeira opção = Soma!
                Console.WriteLine("1.Somar");

                //Segunda opção = Subtração!
                Console.WriteLine("2.Subtrair");

                //Terceira opção = Divisão!
                Console.WriteLine("3.Divisão");

                //Quarta opção = Multiplicação
                Console.WriteLine("4.Multiplicação");

                //Sair do programa!
                Console.WriteLine("0-sair");

                //Convertendo a variável e lendo a linha escrita escolhida!
                op = int.Parse(Console.ReadLine());




                if (op == 0)
                {
                    break;
                }
                //Se a opção for 1, iremos para o menu de soma!
                else if (op == 1)
                {
                    Somar();
                }
                //Se a opção for 2, iremos para o menu de subtração!
                else if (op == 2)
                {
                    Subtração();
                }
                //Se a opção for 3, iremos para o menu de divisão!
                else if (op == 3)
                {
                    Divisão();
                }
                //Se a opção for 4, iremos para o menu de multiplicação!
                else if (op == 4)
                {
                    Multiplicação();
                }
                //Caso o indivíduo digite 0, finalizará o processo!
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }

        private static void Multiplicação()
        {//Menu de multiplicão, o indivíduo escolherá dois números, ambos serão multiplicados e o resultado será informado !
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" " + n1 + "*" + n2 + "*" + (n1 * n2));
            Console.ReadKey();
            
        }

        private static void Divisão()
        {//Menu de divisão, o indivíduo escolherá dois números, ambos serão divididos e o resultado será informado!
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" " + n1 + "/" + n2 + "=" + (n1 / n2));
            Console.ReadKey();

        }

        private static void Subtração()

        { //Menu de subtração, o indivíduo escolherá dois números, ambos serão subtraídos e o resultado será informado
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" " + n1 + "-" + n2 + "=" + (n1 - n2));
            Console.ReadKey();


        }

        private static void Somar()

        {//Menu de soma, o indivíduo escolherá dois números, ambos serão somados e o resultado será informado!
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" "+n1+"+"+n2+"="+(n1+n2));  
            Console.ReadKey();


        }
    }
}
