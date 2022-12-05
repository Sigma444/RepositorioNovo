using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condições_SwitchCase 
{ 

    internal class Program
    {
        static void Main(string[] args)
        {//A pessoa deve escolher uma das três opções disponíveis
        Console.WriteLine("Escolha uma das seguintes opções");
        //Na primeira opção, a pessoa terá a criação de um ficheiro
        Console.WriteLine("1-Criar um ficheiro");
        //Na segunda opção, a pessoa irá abrir o ficheiro existente
        Console.WriteLine("2-Abrir ficheiro");
        //Na terceira opção,a pessoa irá gravar o ficheiro
        Console.WriteLine("3-Gravar ficheiro");
        //Na quarta opção, a pessoa finaliza o processo 
        Console.WriteLine("0-Sair");
        //Conversão da variável string para op
        int op = int.Parse(Console.ReadLine());
            
        //Switch irá especificar e identificar a opção escolhida pelo indivíduo
            switch (op)
            {
            //O primeiro caso será identificado como opção 1
                case 1:
                    Console.WriteLine("Escolheu a opção 1-Criar um novo ficheiro");
                    break;
            //O segundo caso será identificado como opção 2
                case 2:
                    Console.WriteLine("Escolheu a opção 2-Abrir um ficheiro existente");
                    break;
            //O terceiro caso será identificado como opção 3
                case 3:
                    Console.WriteLine("Escolheu a opção 3-Gravar o ficheiro");
                    break;
            //O caso 0 significará a finalização do processo
                case 0:
                    break;
            //FIM! 
                default: Console.WriteLine("Opção inválida");
                    break;
            }

        }

  
    }
}
