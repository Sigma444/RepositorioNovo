using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op.Relacionais_e_Lógicos
{
    internal class Program
    {
        static void Main(string[] args)
        { //Testando !
            bool Valorlogico;
            Valorlogico = true; //mude para false para ver o resultado
            Valorlogico = !Valorlogico; //invertendo o valor lógico
            Console.WriteLine(Valorlogico.ToString()); //Resultado impresso é o inverso do fornecido à variável


            Console.ReadLine();


            //Testando &&:

            int idade;
            bool idadeValida;
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            idadeValida = (idade > 0) && (idade <= 120);
            Console.WriteLine(idadeValida.ToString());


            //Testando || : pipe
            int temperatura;
            bool temperaturaInvalida;
            Console.WriteLine("Digite a temperatura em graus Célcius para verificar se a água está no estado sólido ou gasoso");
            temperatura = int.Parse(Console.ReadLine());
            temperaturaInvalida = (temperatura < 0) || (temperatura > 100);
            Console.WriteLine(temperaturaInvalida.ToString());  
        }   
    }
}
