using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adicionando a variável string em nomes
            string[] nomes = new string[3];
            
            //Esse loop terá os nomes adicionados no processo, e será finalizado quando receber um valor nulo
         for (int i = 0; i < nomes.Length; i++)
            {
                //O usuário irá inserir os nomes onde for indicado
                Console.WriteLine("Insira o " + (i + 1) + "º nome");
                //Aqui serão exibidos os nomes adicionados
                nomes[i] = Console.ReadLine();
            }
           //Aqui o usuário será informado que deve escolher uma posição do nome de acordo com os quais escreveu anteriormente
            Console.WriteLine("Qual a posição que quer ver?");
            //Convertendo a variável inteira para ser lido na linha que o usuário escreveu
            int pos = int.Parse(Console.ReadLine())  -1;

            //Será exibido o nome de acordo com a posição que o usuário escolheu
            Console.WriteLine(nomes[pos]);  
        }
    }
}
