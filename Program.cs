using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cópia_Melhorada
{
    //Adicionando o enumerador de jogos por gênero
    public enum TipoGenero { Ação, Aventura, Casual, Puzze, Estratégia, Outro }
    //Adicionando o enumerador de jogos por console
    public enum TipoConsole { PS4, PS5, Switch, Xbox_one, PC, Outro }
    //Classe do jogo
    public class jogo
    {


        public jogo() //Informações armazenadas
        {   //Classificação do Id do jogo
            this.Id = 1;
            //Classificação do Nome do jogo
            this.Nome = "";
            //Classificação da descrição do jogo
            this.Descricao = "";
            //Classificação do Gênero do jogo
            this.Genero = TipoGenero.Outro;
            //Classificação do Console do Console do jogo
            this.Console = TipoConsole.Outro;
        }
        //Ir]nformações que serão mostradas para o indivíduo
        public jogo(int id, String nome, String descriçao, TipoGenero genero, TipoConsole console)

        {
            //Id do jogo
            this.Id = id;
            //Nome do jogo
            this.Nome = nome;
            //Descrição do jogo
            this.Descricao = descricao;
            //Gênero do jogo
            this.Genero = genero;
            //Console do jogo
            this.Console = console;

        }
        //Registrando o id no algoritmo
        private int id;


        public int Id;

        //Registrando o Nome do algoritmo
        public string Nome;

        //Resgistrando a Descrição no algoritmo
        private String descricao;

        public String Descricao;

        //Registrando o Gênero no algoritmo
        public TipoGenero Genero { get; set; }

        //Registrando o Console no algoritmo
        public TipoConsole Console { get; set; }
    }


    //Classe controle de jogos
    //Banco de dados
    public class ListaDeJogos
    {
        //Cria a lista de jogos
        private List<jogo> jogos;

        public List<jogo> Jogos
        {
            get
            {
                return jogos;
            }

        }

        public ListaDeJogos()
            //Novos jogos na lista
        {
            jogos = new List<jogo>();
        }
        //Adicionando método para inserir jogos
        public Boolean Inserir(jogo jogo)
        {
            Boolean resultado = true;
            try
            {//Aqui o sistema adiciona o jogo no banco de dados
                jogo j = jogos.Find(x => x.Id == jogo.Id);
                if (j == null)
                {
                    jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }
                return resultado;

            }
            catch (Exception erro)
            {
                resultado = false;
            }
            return resultado;

        }
        //Adicionando método para alterar o jogo
        public Boolean Alterar(jogo jogo)
        {//Alterando o jogo e enviando alteração pro banco de dados
            Boolean resultado = false;
            jogo j = jogos.Find(x => x.Id == jogo.Id);
            if (j != null)
            {//Aqui o usuário insere as caracteísticas do jogo, como nome, descrição, gênero e console
                j.Nome = jogo.Nome;
                j.Descricao = jogo.Descricao;
                j.Genero = jogo.Genero;
                j.Console = jogo.Console;
                resultado = true;
            }
            return resultado;
        }
        //Adicionando método para excluir jogo
        public Boolean Excluir(int id)
        {
            //Adcionando a remoção no banco de dados 
            Boolean resultado = false;
            jogo j = jogos.Find(x => x.Id == id);
            if (j != null)
            {
                resultado = jogos.Remove(j);
            }
            return resultado;

        }
        //Adicionando método de localização de jogos
        public List<jogo> Localizar(String nome)
        {
            //Localizando o jogo no banco de dados
            List<jogo> lj = jogos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return lj;
        }

        //Adicionando método de listar jogo por Gênero
        public List<jogo> ListaPorGenero(TipoGenero console)
        {
            //listando os gêneros no banco de dados 
            List<jogo> lj = jogos.FindAll(x => x.Console.Equals(console));
            return lj;

        }
        //Adicionando método de listar jogo por console
        public List<jogo> ListarPorConsole(TipoConsole console)
        {
            //Listando o jogo no banco de dados
            List<jogo> lj = jogos.FindAll(x => x.Genero.Equals(console));
            return lj;
        }

    }
    class program
    {
        //Aqui se apresenta o menu que o usuário terá acesso
        static int ShowMenu()
        {//Cada número representará um métedo a ser executado pelo algoritmo
            Console.Clear();
            Console.WriteLine("===Controle de jogos===");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("[1] Cadastrar um jogo");
            Console.WriteLine("[2] Excluir um jogo");
            Console.WriteLine("[3] Alterar um jogo");
            Console.WriteLine("[4] Localizar um jogo por nome");
            Console.WriteLine("[5] Listar os jogos por Genero");
            Console.WriteLine("[6] Listar os jogos por Console");
            Console.WriteLine("[7] Listar todos os jogos");
            Console.WriteLine("[8] Sair");
            //Conversão da variável na linha escrita escolhida pelo usuário. 
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)

        {//Criando uma nova lista de jogos
            ListaDeJogos listadejogos = new ListaDeJogos();
            List<jogo> lista = new List<jogo>();
            String nomejogo = "";
            int id = 0;
            //Adicionando o jogo "Ty Runner" e suas identificações
            jogo jogo = new jogo(1, "Ty Runner", "Jogo de corrida infinita", TipoGenero.Aventura, TipoConsole.Outro);
            listadejogos.Inserir(jogo);
            //Adicionando o jogo "Jackpot" e suas identificações
            jogo = new jogo(2, "Jackpot", "Caça-Níquel", TipoGenero.Casual, TipoConsole.Outro);
            listadejogos.Inserir(jogo);
            //Adicionando o jogo "Faroeste zumbi" e suas identificações
            jogo = new jogo(3, "Faroeste zumbi", "Jogo de tiro", TipoGenero.Ação, TipoConsole.PC);
            listadejogos.Inserir(jogo);
            //Adicionando o jogo "Bomba patch" e suas identificações
            jogo = new jogo(4, "Bomba Patch 100% Atualizado", "Futebol",TipoGenero.Outro, TipoConsole.Outro);
            listadejogos.Inserir(jogo);

            int op = 0; //Valor da operação que o usuário irá realizar
            while (op!= 9)
            {
                op = ShowMenu();
                Console.Clear();
                switch(op)
                {//No primeiro caso o usuário irá inserir um jogo no algoritmo
                    case 1: //Inserir
                        Console.WriteLine("Inserir um novo jogo");
                        jogo = new jogo();
                        Console.WriteLine("Id: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nome: ");
                        jogo.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o Gênero Acao[0], Aventura[1], Casual[2], Puzze[3], Estratégia [4], Outro[5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32((Console.ReadLine()));
                        Console.WriteLine("Informe o console PS4 [0], PS5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32((Console.ReadLine()));
                        if (listadejogos.Inserir(jogo))
                        {
                            //Caso seja verdadeiro, o usuário será informado que o jogo foi inserido
                            Console.WriteLine("JOGO INSERIDO!!!!");
                        }
                        else
                        {
                            //Caso seja falso, o usuário será informado que o jogo não foi inserido
                            Console.WriteLine("JOGO NÃO INSERIDO!!!!");
                        }
                        Console.ReadKey();
                        break;
                    
                    //No segundo caso o usuário irá excluir um jogo no algoritmo
                     case 2: //Excluir
                        Console.WriteLine("Excluir jogo");
                        Console.WriteLine("Informe o ID do jogo");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (listadejogos.Excluir(id)) 
                        {
                            //Caso seja verdade, o usuário será informado que o jogo foi excluído
                            Console.WriteLine("JOGO EXLUÍDO!!!!");

                        }
                        else
                        {
                            //Caso seja falso, o usuário será informado que o jogo não foi excluído
                            Console.WriteLine("JOGO NÃO EXCLUÍDO");
                        }
                        Console.ReadKey();
                        break;

                    //No terceiro caso o usuário irá alterar o jogo no algoritmo
                    case 3://alterar
                        Console.WriteLine("Alterar um jogo");
                        jogo = new jogo();
                        Console.Write("Id: ");
                        jogo.Id= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nome: ");
                        jogo.Nome = Console.ReadLine();
                        Console.WriteLine("Descrição: ");
                        jogo.Descricao= Console.ReadLine();
                        Console.WriteLine("Informe o Genero Acao[0], Aventura[1], Casual[2], Puzze[3], Estrategia[4], Outro[5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Console PS4[0], PS5[1], Switch[2], Xbox 360[3], Xbox One[4], PC[5], Outro[6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());    
                        if (listadejogos.Alterar(jogo))
                        {
                            //Caso seja verdade, o usuário será informado que o jogo foi alterado
                            Console.WriteLine("JOGO ALTERADO COM SUCESSO!!!!");
                        }
                        else
                        {
                            //Caso seja falso, o usuário será informado que o jogo não foi alterado
                            Console.WriteLine("JOGO NÃO ALTERADO!!!!");
                        }
                        Console.ReadKey();
                        break; 

                        //No quarto caso o usuário irá localizar um jogo pelo nome no algoritmo
                        case 4://Localizar por nome
                        Console.WriteLine("Localizar jogos");
                        Console.WriteLine("Informe o nome do jogo: ");
                        nomejogo = Console.ReadLine();
                        lista = listadejogos.Localizar(nomejogo);
                        

                        foreach (var j in lista)
                        {
                            //Aqui o programa executa uma validação de acordo com a opção escolhida
                            Console.WriteLine("Id: " + j.Id);
                            Console.WriteLine(" - Nome: " + j.Nome);
                            Console.WriteLine(" - Descricao: " + j.Descricao);
                            Console.WriteLine(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine(" Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                        //No quinto caso o usuário írá listar um jogo por gênero
                        case 5: //Listar gênero
                        Console.WriteLine("Listar todos os jogos por gênero");
                        Console.WriteLine("Informe o Gênero do jogo Acao[0], Aventura[1], Casual[2], Puzze[3], Estrategia[4], Outro[5]: ");
                        TipoGenero genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        lista = listadejogos.ListaPorGenero(genero);

                        foreach (var j in lista)
                        {
                            //Aqui o programa executa a validação de todas as características de acordo com o banco de dados
                            Console.WriteLine("Id: " +j.Id);
                            Console.WriteLine(" - Nome: " + j.Nome);
                            Console.WriteLine(" - Descricao: " + j.Descricao);
                            Console.WriteLine(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);


                        }
                        Console.WriteLine("Aperte em qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                        //No sexto caso o uuário irá listar um jogo por console
                        case 6://Listar Console
                        Console.WriteLine("Listar todos os jogos por console");
                        Console.WriteLine("Informe o console PS4[0], PS5[1], Swtich[2], Xbox 360[3], Xbox One[4], PC[5], Outro[6]: ");
                        TipoConsole console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        lista = listadejogos.ListarPorConsole(console);


                        foreach (var j in lista)
                        {
                            //Aqui o programa executa a validação de todas as características de acordo com o banco de dados
                            Console.WriteLine("Id: " +j.Id);
                            Console.WriteLine(" - Nome: " + j.Nome);
                            Console.WriteLine(" - Descricao: " + j.Nome);
                            Console.WriteLine(" - Genero:" + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey(); 
                        break;

                        //No sétimo caso o usuário irá listar todos os jogos que estão no banco de dados
                        case 7://Listar todos os jogos
                        Console.WriteLine("Listar todos os jogos");
                        foreach (var j in listadejogos.Jogos)
                        {
                            //Aqui o programa executa a validação de todas as características de acordo com o banco de dados
                            Console.WriteLine("Id: " + j.Id);
                            Console.WriteLine(" - Nome: " + j.Nome);
                            Console.WriteLine(" - Descricao: " + j.Descricao);
                            Console.WriteLine(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);

                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        //FIM!!
                        Console.ReadKey();
                        break;
                        






                        





                }
            }





        }






















    }
} 
            
