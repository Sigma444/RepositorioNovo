using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_e_arrays_mano_e_multidimensionais
{
    internal class Program
    {
        //Serão apresentadas duas formas diferentes de arrays na primeira aula,porém, as duas daão o mesmo resultado!!!
        static void Main(string[] args)
        {//Aqui classificamos todos os nomes como string. Sendo 1,2,3 e 4
            string nome1 = "Ana Silva";
            string nome2 = "Jose Martins";
            string nome3 = "Afonso Teixeira";
            string nome4 = "Maria Gomes";

            //Nessa parte o usuário será informado com os nomes disponíveis
            Console.WriteLine("Nome 1: " + nome1);
            Console.WriteLine("Nome 2: " + nome2);
            Console.WriteLine("Nome 3: " + nome3);
            Console.WriteLine("Nome 4: " + nome4);
            Console.WriteLine("---------------------------------------------------------");

            //No segundo método teremos uma forma mais rápida de executar o processo

            //Utilizando o método de New string para adicionar os 4 nomes de uma vez só
            string[] nomes = new string[] { "Ana", "Jose", "Afonso","Maria"  };

            //Da mesma forma vamos classificar os sobrenomes de cada nome
            string[] sobrenomes = new string[4];
           
            //Cada Sobrenome tem seu número 
            sobrenomes[0] = "Silva";
            sobrenomes[1] = "Martins";
            sobrenomes[2] = "Teixeira";
            sobrenomes[3] = "Gomes";
            
            //Nesse for, será feito um loop com todos os nomes dentro dele, será finalizado quando encontrar um valor nulo
            for (int i = 0; i < nomes.Length; i++)
            {
                //Nesse espaço, o usuário será informado com os nomes e seus respectivos nomes!
                Console.WriteLine("Nome " + (i + 1) + ": " + nomes[i] + " " + sobrenomes[i]);
            }
            // AULA 2

            Random rnd = new Random();

            int[] numeros = new int[500];
             for (int i = 0; i < numeros.Length; i++)
            {
                numeros[1] = rnd.Next(1, 100);
                Console.Write(numeros[1]+ "  " );
            }
        }

    }
}
