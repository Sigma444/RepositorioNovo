using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cassino_Menus_e_Random
{//O projeto consiste em um sistema de apostas, com loteria, raspadinhas, levantamentos e depósitos que o usuário pode usar
    internal class Program
    {
        //Adicionando o método RANDOM. O RANDOM serve para gerar um número dentro de alguma limitação escolhida pelo sistema!
       static Random rnd = new Random();
        //Adicionando a variável string "nome", a qual o usuário irá se identificar
        static string nome = "";
        //Adicionando a variável inteiro, pela qual o usuário tem acesso ao próprio saldo (O saldo inicial é 100)
        static int saldo = 100;

        //Nesse campo, o usuário irá se identificar no sistema, em seguida terá acesso ao programa e suas opções
        static void Main(string[] args)
        {
            //O usuário insere o nome para identificação
            Console.Write("Qual o seu nome?  ");

            //O sistema lê a linha escrita, no caso, o nome do usuário!
            nome = Console.ReadLine();  

            int op = 1;
            
            //O while vai resultar numa lista de comandos "infinitos", ou os chamados "ciclos", que sempre será apresentada do início do programa, apresentando todas as opções disponíveis ao usuário
            while(op != 0)
            {
                //Aqui o programa dá as boas vindas ao usuário, ja com o nome inserido e apresentando o saldo atual
                Console.WriteLine("Bem-Vindo, " +nome+ "\t\tSeu Saldo é: "+ saldo);
                //Nessa parte o usuário deverá escolher uma das opções de acordo com seu respectivo número
                Console.WriteLine("Escolha uma das seguintes opções");
                //A primeira opção é a loteria, onde serão jogados números aleatórios e resultará no número premiado
                Console.WriteLine("1- Loteria");
                // A segunda opção são as raspadinhas, onde haverá um menu com duas raspadinhas diferentes, o usuário deverá escolher uma delas para jogar
                Console.WriteLine("2- Raspadinhas");
                //Na terceira e última opção, o usuário poderá fazer levantamentos, que são valores que ele tirará do próprio saldo para apostar. E também poderá fazer depósitos para aumentar o saldo de jogo 
                Console.WriteLine("3- Levantamentos e depósitos");
                //Nessa opção o usuário sai do menu e volta ao início do while
                Console.WriteLine("0- Sair");
                //Aqui ocorre a conversão da variável para a leitura das linhas escritas acima
                op = int.Parse(Console.ReadLine());

            //O método switch apresentará cada caso de forma separada, de acordo com as opções que o usuário escolhe no WHILE!
             switch (op)
                {
                    
                    case 0:
                        break;
                        //No primeiro caso se trata da Loteria
                    case 1 : 
                            Loteria();
                        break;

                        //No segundo caso se trata das raspadinhas
                    case 2 :
                        Raspadinhas();
                            break;

                        //No terceiro e último nós temos a banca, que se trata dos levantamentos e depósitos!
                    case 3 :
                        Banca();
                       break; 
                  
                       
                    //O default irá auxiliar a informar o usuário que selecionar uma opção fora dos parâmetros disponibilizados
                    default: Console.WriteLine("opção inválida");
                        //FIM!
                    Console.ReadKey ();
                        break;
                    


                }
            } 
        }
        //Temos aqui o método da banca 
        private static void Banca()
        {
            int op = 1;
            //Esse while será para o ciclo relacionado á banca, onde serão feitos os levantamentos e os depósitos
            while (op != 0) 
            {
                //Limpa o console
                Console.Clear();
                //O ciclo dá as boas vindas ao usuário e apresenta novamente o saldo disponível
                Console.WriteLine("Bem-Vindo, " + nome + "\t\tSeu Saldo é: " + saldo);            
                //O usuário deverá escolher uma opção disponível
                Console.WriteLine("Escolha uma das seguintes opções");
                //Na primeira opção temos os levantamentos que poderão ser feitos 
                Console.WriteLine("1- Levantamento");
                //Na segunda opção temos os depósitos que poderão ser feitos
                Console.WriteLine("2- Depósito");
                //A opção 0 volta ao menu anterior do while
                Console.WriteLine("0- Voltar ao menu anterior");
                //Conversão da varívael para inteiro e leitura da linha escrita
                op = int.Parse(Console.ReadLine());

                //Nesse switch nós teremos os dois casos disponíveis nas opções da banca
                switch(op)
                {

                    case 0: break;
                    //Caso 1 temos os levantamentos
                    case 1 : Levantamento(); break;

                    //Caso 2 temos os depósitos
                    case 2 : Depósito(); break;

                    //O default nos auxilia a informar ao usuário que ele escolheu uma opção inválida
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey (); break;

                }
            }

        }

        //Temos aqui o método do depósito
        private static void Depósito()
        {
            //Limpa o console
            Console.Clear();
            //Apresenta o saldo atual ao usuário
            Console.WriteLine("Saldo atual: " + saldo);
            //Pergunta qual valor o usuário quer depositar
            Console.WriteLine("Qual o valor a depositar?");
            //Ele converte a variável a inteira para ler a linha escrita acima
            int valor = int.Parse (Console.ReadLine());

            //Aqui nós somamos o saldo que resultará em algum valor maior após o depósito
            saldo += valor;
            
            //O usuário é informado que seu depósito foi feito com êxito
            Console.WriteLine("Depósito realizado com sucesso, novo salto: " + saldo);
            //FIM!!
            Console.ReadKey();
        }
       
        //Temos aqui o método de levantamento
        private static void Levantamento()
        {
            //Limpa o console
            Console.Clear();
            //O saldo do usuário é informado 
            Console.WriteLine("Saldo atual: " + saldo);
            //Aqui o usuário escolhe o valor que quer depositar
            Console.WriteLine("Qual o valor a levantar?");
            //Converte a variável inteira para ler a linha escrita acima
            int valor = int.Parse(Console.ReadLine());

            //Se o valor do levantamento for maior que o saldo disponível, será informada a insuficiência no saldo do usuário
           if (saldo - valor < 0)
            {
                //Informação de saldo insuficiente
                Console.WriteLine("Saldo insuficiente");
            }

           //Mas no caso de saldo suficiente, o levantamento será feito com sucesso
           else
            {
                //Aqui será retirado o valor do levantamento feito, logo após mostrará o saldo atual já com o valor retirado
                saldo -= valor;
                //O usuário é informado que o levantamento foi feito com sucesso
                Console.WriteLine("Levantamento realizado com sucesso,saldo atual de R$: " +saldo);
            }
           //FIM!!
           Console.ReadKey();
        }

        //Temos aqui o método de raspadinhas 
        private static void Raspadinhas()
        {
            int op = 1;
            //Neste ciclo while teremos as opções de raspadinhas num menu separado
            while (op != 0)
            {
                //Limpa o console
                Console.Clear();
                //Apresenta o menu de raspadinhas
                Console.WriteLine("Menu Raspadinhas");
                //Opção 1 se refere ao primeiro modelo de raspadinha
                Console.WriteLine("1-Raspadinha A");
                //Opção 2 se refere ao segundo modelo de raspadinha
                Console.WriteLine("2-Raspadinha B");
                //Opção 0 volta ao menu de início do ciclo while
                Console.WriteLine("0-Voltar ao menu anterior");
                //Converte a variável inteira para ler a linha escrita
                op = int.Parse(Console.ReadLine());

                
                if (op == 0)
                    break;
                

                //Opção de raspadinha A escolhida
                else if (op == 1)
                    RaspadinhaA();         
                
                //Opção de raspadinha B escolhida
                else if (op == 2)
                    RaspadinhaB();

                //Se o usuário digitar uma opção fora dos parâmetros, será informado pela opção inválida
                else

                {
                    //Opção inválida informada
                    Console.WriteLine("Opção inválida");
                    //FIM!! 
                    Console.ReadKey();
                }

            }
        }

        //Temos aqui o método de raspadinha "B"
        private static void RaspadinhaB()
        {
            //Limpa o console
            Console.Clear();

            //Se o saldo for menor que 2, será informado ao usuário que o saldo é insuficiente
            if (saldo - 2 < 0) 
            {
                //Aqui é informada a insuficiência de saldo, e é feito um pedido de depósito
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                //Fim!!
                Console.ReadKey();
                //Retorna ao início 
                return;
            }
            //O n principal seráo número sorteado de forma aleatória
            int nprincipal = rnd.Next(1, 10);
            //O prêmio será o número sorteado
            int premio = rnd.Next(1, 100);

            //Serão escolhidos números de 1 a 10 de forma aleatória
            int n1 = rnd.Next(1, 10);
            int n2 = rnd.Next(1, 10);
            int n3 = rnd.Next(1, 10);
            int n4 = rnd.Next(1, 10);
            int n5 = rnd.Next(1, 10);
            int n6 = rnd.Next(1, 10);
            int n7 = rnd.Next(1, 10);
            int n8 = rnd.Next(1, 10);
            int n9 = rnd.Next(1, 10);

            //A variável inteira "CONT" servirá como contador no sistema
            int cont = 0;

            //Aqui será escolhido o primeiro Número sorteado que será nomeado "N1".. O ++ significa um acréscimo de contagem após a execução do primeiro número escolhido
            if (nprincipal == n1) cont++;

            //Aqui será escolhido o segundo número que será nomeado por "N2"
            if (nprincipal == n2) cont++;

            //Aqui será escolhido o terceiro número que será nomeado por "N3"
            if (nprincipal == n3) cont++;

            //Aqui será escolhido o quarto número que será nomeado por "N4"
            if (nprincipal == n4) cont++;

            //Aqui será escolhido o quinto número que será nomeado por "N5"
            if (nprincipal == n5) cont++;

            //Aqui será escolhido o sexto número que será nomeado por "N6"
            if (nprincipal == n6) cont++;
            
            //Aqui será nomeado o sétimo número que será nomeado por "N7"
            if (nprincipal == n7) cont++;

            //Aqui será escolhido o oitavo número que será nomeado por "N8"
            if (nprincipal == n8) cont++;

            //Aqui será escolhido o nono número que será nomeado por "N9"
            if (nprincipal == n9) cont++;

            //Será informado ao usuário seu número escolhido e o número que foi premiado
            Console.WriteLine("Número principal: " +nprincipal + " ("+premio+")");

            //Nesse campo são informados todos os números sorteados

            //Primeira linha de números sorteados
            Console.WriteLine(n1+" "+n2+" "+n3);
            //Segunda linha de números sorteados
            Console.WriteLine(n4+" "+n5+" "+n6);
            //Terceira linha de números sorteados
            Console.WriteLine(n7+" "+n8+" "+n9);


            //Se o contador apresentar menor ou igual a 3, significa que o número foi premiado
            if (cont>=3)
            { 
                //O usuário é informado que foi premiado
                Console.WriteLine("PARABÉNS, FOI PREMIADO!! GANHOU "+premio);
                //Soma do prêmio ao saldo
                saldo += premio;

            }
               
            //Caso contrário, o número não será escolhido
            else
                //O usuário é informado que não foi premiado
                Console.WriteLine("RASPADINHA NÃO PREMIADA");



            //FIM!!
            Console.ReadKey();
            
        }

        //Temos aqui o método de raspadinha "A"
        private static void RaspadinhaA()
        {
            //Limpa o console
           Console.Clear();
            //Se o saldo for menor que 2, significa que o saldo não é suficiente. Será solicitado um depósito
            if (saldo - 2 < 0) 
            {
                //O usuário é informado que o saldo não é suficiente e é necessário um depósito
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                //FIM!! 
                Console.ReadKey();
                //Retorna ao início 
                return;
            }
            //O n principal será o número escolhido de forma aleatória
            int nprincipal = rnd.Next(1, 10);
            //Aqui serão sorteados os números de forma aleatória. Os números serão nomeados de "N" e a númeração de acordo com a sequência. Os prêmios serão nomeados de "P" e a numeração de acordo com a sequência
            int n1 = rnd.Next(1, 10);  int p1 = rnd.Next(1, 100);           
            int n2 = rnd.Next(1, 10);  int p2 = rnd.Next(1, 100);
            int n3 = rnd.Next(1, 10);  int p3 = rnd.Next(1, 100);
            int n4 = rnd.Next(1,10);   int p4 = rnd.Next(1, 100);
            int n5 = rnd.Next(1, 10);  int p5 = rnd.Next(1, 100);
            
            //Aqui o Nprincipal será o número escolhido pelo usuário
            Console.WriteLine("Número principal: " + nprincipal);

            //Será informado o valor do N1 e P1
            Console.WriteLine("1- Número: "+n1+ "("+p1+")");
            //Aqui será informado o valor do N2 e P2
            Console.WriteLine("2- Número: " + n2 + "(" + p2 + ")");
            //Aqui será informado o valor do N3 e P3
            Console.WriteLine("3- Número: " + n3 + "(" + p3 + ")");
            //Aqui será informado o valor do N4 e P4
            Console.WriteLine("4- Número: " + n4 + "(" + p4 + ")");
            //Aqui será o informado o valor do N5 e P5
            Console.WriteLine("5- Número: " + n5 + "(" + p5 + ")");

            //Adicionando a inteira que representará o prêmio
            int premio = 0;

            //Se o n1 for igual ao número escolhido pelo usuário, será adquirido o p1
            if (n1 == nprincipal) premio += p1;

            //Se o n2 for igual ao número escolhido pelo usuário, será adquirido o p2
            if (n2 == nprincipal) premio += p2;

            //Se o n3 for igual ao número escolhido pelo usuário, será adquirido o p3
            if (n3 == nprincipal) premio += p3;

            //Se o n4 for igual ao número escolhido pelo usuário, será adquirido o p4
            if (n4 == nprincipal) premio += p4;

            //Se o n5 for igual ao número escolhido pelo usuário, será adquirido o p5
            if (n5 == nprincipal) premio += p5;
            
            //Aqui é informado o prêmio que foi concedido ao usuário
            Console.WriteLine("Prêmio: " + premio);
            //Soma do saldo com o prêmio
            saldo += premio;

            //FIM!!
            Console.ReadKey();

        }

        //Temos aqui o método de loteria
        private static void Loteria()
        {
            //Limpa o console
            Console.Clear(); 
            //N premiado será o número sorteado de forma aleatória
            int npremiado = rnd.Next(1000, 10000);

            //Se o saldo do usuário for menor que5, será informado o saldo insuficiente
             if (saldo - 5 < 0) 
            
            {
                //Informação do saldo insuficiente e o pedido de depósito ao usuário
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                //FIM!!
                Console.ReadKey();
                //Retorna ao início
                return;

            }
             //Adicionada a inteira do número do jogador
            int njogador = 0;

            //Ciclo while voltado para apresentar as opções do menu da loteria
            while (njogador < 1000 ||  njogador > 9999)
            {
            //Aqui o usuário escolhe o número entre 1000-9999 para jogar
            Console.WriteLine("Qual número quer jogar na loteria? (1000-9999)");
            //Converte a variável inteira do jogador para ler a linha escrita acima
            njogador = int.Parse(Console.ReadLine());
           
            }
            //Informação ao usuário de qual bilhete foi premiado
            Console.WriteLine("Bilhete premiado: " +npremiado);
            
            //Se o bilhete premiado for igual ao do usuário, significa que ele foi premiado
            if(npremiado == njogador)
            {
                //Informação da premiação ao usuário
                Console.WriteLine("PARABÉNS, VOCÊ GANHOU O PRIMEIRO PRÊMIO");
                //Soma do saldo com a premiação
                saldo += 10000;
            }
            //Caso o número do jogador tiver DOIS números iguais ao sorteado, ele ganhará o segundo prêmio
            else if (npremiado%1000 == njogador%1000)
            { 
                //Informação da premiação ao usuário
                Console.WriteLine("PARABÉNS, VOCÊ GANHOU O SEGUNDO PRÊMIO");
                //Soma do saldo com o prêmio
                saldo += 1000;
            }
            //Caso o número do usuário tenha apenas UM NÚMERO igual ao número premiado, significa que ele ganhou o terceiro prêmio
            else if (npremiado%100 == njogador%100)
            {
                //Informação da premiação ao usuário
                Console.WriteLine("PARABÉNS, VOCÊ GANHOU O SEGUNDO PRÊMIO");
                //Soma do saldo com a premiação
                saldo += 100;
            }
            //Se o número do usuário não possuir nenhum número condizente com o número premiado, significa que ele não foi premiado
            else
            {
                //Informação ao usuário de que ele não foi premiado
                Console.WriteLine("SEU BILHETE NÃO FOI PREMIADO");
            }
            //FIM!!
            Console.ReadKey();
        }
    }
}
