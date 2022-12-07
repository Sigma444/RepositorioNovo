using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ciclo_FOR
{
    internal class Program
    {
        

        static void Main(string[] args)

           
        {   //O comando define onde começa e quantos números diferentes podem ser somados 
            int soma=0;
            for (int i = 0; i < 3; i++)
            {//O indivíduo deverá inserir um número
                Console.WriteLine("Insira um número");
             //Conversão da variável de string para inteiro
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }  //Defina a soma e o resultado final de todos os valores inseridos 
            Console.WriteLine("A soma dos valores inseridos é: "+soma);

            //FIM!
            Console.ReadKey();  
            
        }
    }
}
