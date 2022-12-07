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
        //Qualquer número inserido que seja diferente de zero será somado !
        { int num=1, soma=0; 
        //A condição só valerá para números diferentes de zero!
            while (num!=0) 
            {
        //O indivíduo irá inserir um valor para ser somaddo, e colocará "0" para finalizar o processo
                Console.WriteLine("Insira um valor para somar! Insira 0 para parar");
        //Conversão da variável String para inteiro, e ler a linha escrita !
                num = int.Parse(Console.ReadLine());
        // A soma resultará em um número
                soma += num;
                
            }
        //Informa o indivíduo o valor da soma feita com os valores inseridos
            Console.WriteLine("A soma de todos os números inseridos é: " + soma);
            
        //FIM! (Palmeiras nao tem mundial)
            Console.ReadKey();  


        } 
        
    }
}
