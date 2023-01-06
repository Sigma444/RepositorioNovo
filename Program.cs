using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //Adicionando a variável double como "notas"
            double[] notas = new double[3];

            //Será criado um loop, com todas as notas que estão nele, será encerrado quando houver um valor nulo
            for (int i = 0; i < notas.Length; i++)
            {
                //O usuário deverá inserir a nota desejada de acordo com a sequência disponibilizada
                Console.WriteLine("Insira a " + (i + 1) + "ª nota");
                //Converte a variável double para linha escrita ler as notas que foram inseridas
                notas[i] = double.Parse(Console.ReadLine());
            }
            //Adicionando a variável double cpmo soma 
            double soma = 0;

            //Neste loop, estarão as notas já inseridas pelo usuário, que serão somados os resultados finais resultando na média!
            for (int i = 0; i < notas.Length; i++)
            {
                //A soma das notas será calculada 
                soma += notas[1];
            }
            //Aqui o usuário será notificado da média final de acordo com as notas que inseriu no sistema
            Console.WriteLine("A média é : "+(soma/notas.Length));


            
        }
    }    
}
