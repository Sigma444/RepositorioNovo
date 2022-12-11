using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex.4 Faça um programa que receba o valor que é o preço, um segundo valor que é o valor pago do produto e um terceiro valor que será o troco a ser dado
            /* double vPago, vPreço, troco;
             Console.WriteLine("Insira o valor do preço");
              vPreço = double.Parse(Console.ReadLine());

             Console.WriteLine("Valor pago");
             vPago = double.Parse(Console.ReadLine());

             troco = vPago - vPreço;

             if (troco > 0)
                 Console.WriteLine("O troco a ser dado é:" + troco);
             else if (troco < 0)
                 Console.WriteLine("Faltam a pagar " + (vPreço - vPago));
             else
             {
                 Console.WriteLine("Não há troco");
             }*/










            //Ex.5 
            /*  double vKg, quantidade, vPg;


              Console.WriteLine("Digite o valor do KG");
              vKg= double.Parse(Console.ReadLine());

              Console.WriteLine("Digite a quantidade de KG desejada");
              quantidade = double.Parse(Console.ReadLine());

              vPg = quantidade * vKg ;

              Console.WriteLine("O valor a ser pago é:R$ " + vPg);*/


            Double valor1, valor2;

            Console.WriteLine("Digite o Primeiro valor");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor");
            valor2= double.Parse(Console.ReadLine());

            if (valor1< valor2) 
            {
                
                Console.WriteLine("O valor mais alto é o valor: " + valor2);

               
            }
            else if (valor2< valor1) 
            {
               
                
                Console.WriteLine("O valor mais alto é o valor: " + valor1);

            
            }




        }
    }
}
