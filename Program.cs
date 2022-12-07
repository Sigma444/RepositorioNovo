using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CICLO_WHILE
{
    internal class Program
    {
       

        static void Main(string[] args)
        { int num=1, soma=0; 
            while (num!=0) 
            {
                Console.WriteLine("Insira um valor para somar! Insira 0 para parar");
                num = int.Parse(Console.ReadLine());

                soma += num;
                
            }

            Console.WriteLine("A soma de todos os números inseridos é: " + soma);
            


        }
    }
}
