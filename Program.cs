using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Program
    {
     

        static void Main(string[] args)
        {
            string nome;
           //Ex. 1 Criar um algoritmo que lê o nome de uma pessoa e diz "olá" seguido do nome
           
           Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome); 




            //Ex. 2 Crie um algorítmo que apos receber dois números, soma os mesmos
            int n1, n2;
            int soma;
            Console.WriteLine("Insira o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("A soma dos dois valores é: " + soma);






            //Ex.3 Com a base e a altura de um triângulo, calcule sua área
            double b, a, area;

            Console.WriteLine("Qual o valor da base?");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da altura?");
            a = double.Parse(Console.ReadLine());

            area = b * a / 2;
            Console.WriteLine("O valor da área é igual a : " + area);



            Console.ReadKey(); 







        }
    }
}
