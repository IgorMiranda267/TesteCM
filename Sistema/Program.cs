using Sistema;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão 01 -  Calculo da Moda

            int[] vetor = new int[10] { 8, 2, 8, 7, 6, 5, 8, 3, 1, 7 };
            Program.CalculoModa(vetor);
            //-------------x-------------------x-----------------x------------x---------


            //Questão 02 - Ordenação de um vetor
            int[] vetorOrdenacao = new int[8] { 11, 18, 19, 18, 1, 5, 78, 150 };
            Program.OrdenaVetor(vetorOrdenacao);
            //-------------x-------------------x-----------------x------------x---------



            //Questão 03 - Figuras Geometricas
            
            Quadrado q1 = new Quadrado(10);
            Quadrado q2 = new Quadrado(75);
            Quadrado q3 = new Quadrado(28.6);
            Circulo c1 = new Circulo(2);
            Circulo c2 = new Circulo(7);
            Circulo c3 = new Circulo(3.5);
            TrianguloEquilatero t1 = new TrianguloEquilatero(10, 15);
            TrianguloEquilatero t2 = new TrianguloEquilatero(70, 48);
            TrianguloEquilatero t3 = new TrianguloEquilatero(2, 8.75);

            //Adicionando objetos na coleção.
            List<Figura> colecao = new List<Figura>();
            colecao.Add(q1);
            colecao.Add(c2);
            colecao.Add(t3);
            colecao.Add(q2);
            colecao.Add(c3);
            colecao.Add(t1);
            colecao.Add(q3);
            colecao.Add(t2);
            colecao.Add(c1);
            
            //Percorrendo a coleçã e exibindo o tipo e a area.
            foreach (Figura obj in colecao)
            {
                Console.WriteLine(obj.GetType());
                obj.CalcularArea();
                Console.WriteLine("Area: " + obj.Area);
                Console.WriteLine();
            }
            //-------------x-------------------x-----------------x------------x---------

            



            //Questão 04 - Tabelas "N-N"
            /*
             * O modelo a baixo e a relação N-N entre 2 tabelas, Cliente e Conta
             * Quando a relação é N-N tem-se a necessidade de criar uma nova tabela, neste exemplo "depositante"
             * Liguagem usada foi MySql
             * 
             create database banco;
             
            create table cliente (cod_cliente integer not null, nome_cliente char(20) not null,
            rua_cliente char(30), cidade_cliente char(30), primary key (cod_cliente));

            create table depositante (cod_cliente integer not null, numero_conta integer not null,
            cod_agencia integer not null, primary key (cod_cliente, numero_conta, cod_agencia),
            foreign key(cod_cliente) references cliente(cod_cliente), foreign key(numero_conta,
            cod_agencia) references conta(numero_conta, cod_agencia));

            create table conta (numero_conta integer not null, cod_agencia integer not null,saldo
            float, primary key (numero_conta, cod_agencia), foreign key(cod_agencia) references
            agencia(cod_agencia), check (saldo >= 0));
              
             * */

            //-------------x-------------------x-----------------x------------x---------


            

            //Questão 05 - Pilha
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Avião");
            pilha.Push("Fusca 78");
            pilha.Push("Peixe");
            pilha.Push("UFVJM");
            pilha.Push("Sistemas");

            //O segundo argumento define qual string vamos retirar da pilha.
            Program.Pilha(pilha, "Fusca 78");

            Console.WriteLine();
            Console.WriteLine("Pilha com a retirada da string: ");
            foreach (var i in pilha)
            {
                Console.WriteLine(i);
            }
            
            //-------------x-------------------x-----------------x------------x---------



            //Questão 05 - Inverção dos elementos da Diagonal principal
            //A implementação está toda dentro do metodo.
            Program.InverterDiagonal();


            //-------------x-------------------x-----------------x------------x---------

        }


        /* 
         * Questão 01
         * Criei 2 laços, o 1º mantem uma posição fixa
         * e o 2º percorre todo o vetor veridicando se a repetição
         */
        public static void CalculoModa(int[] vetorInteiros)
        {
            int aux = 0, cont = 0, moda = 0;

            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                for (int j = 0; i < vetorInteiros.Length; i++)
                {
                    if (vetorInteiros[i] == vetorInteiros[j])
                    {
                        cont++;
                        if (cont > aux)
                        {
                            aux = cont;
                            moda = vetorInteiros[i];
                        }
                    }
                }
            }

            Console.WriteLine("As moda se repetiu: " + aux);
            Console.WriteLine("O número da moda é: " + moda);
        }


        /*
        * Questão 02
        * 
        */
        public static int[] OrdenaVetor(int[] vetorInteiros)
        {
            int PosiAux, PosiAtual;
            for (int i = 1; i < vetorInteiros.Length; i++)
            {
                PosiAtual = vetorInteiros[i];
                PosiAux = i;
                while ((PosiAux > 0) && (vetorInteiros[PosiAux - 1] > PosiAtual))
                {
                    vetorInteiros[PosiAux] = vetorInteiros[PosiAux - 1];
                    PosiAux = PosiAux - 1;
                }
                vetorInteiros[PosiAux] = PosiAtual;
            }

            for(int x = 0; x < vetorInteiros.Length; x++)
            {
                Console.WriteLine("Vetor: " + vetorInteiros[x]);
            }
            return vetorInteiros;
        }



        /*
         * Questão 05
         * Usei 2 Foreach's:
         * 1º para excluir a string que eu nao queria mais na pilha
         * 2º para retornar o conteudo para prilha que veio como parametro
         */
        public static Stack<string> Pilha(Stack<string> pilha, string remove)
        {
            Stack<string> PilhaAux = new Stack<string>();

            //Console.WriteLine("Pilha Original");
            foreach (var pi in pilha)
            {
                if ( pi.ToString() != remove)
                {
                    PilhaAux.Push(pi.ToString());
                } 
            }

            //Apagando todo conteudo da pilha passada por parametro
            pilha.Clear();

            foreach (var aux in PilhaAux)
            {
                pilha.Push(aux.ToString());
            }
            
            return pilha;
        }


        /*
         *Questão 06 
         */

        public static void InverterDiagonal()
        {
            Console.Write("Digite o tamnha da matriz quadrada que vc desejar: ");
            int tam = int.Parse(Console.ReadLine());

            int[,] mat = new int[tam,tam];
            int[,] matAux = new int[tam, tam];

            int[] dgPricipal = new int[tam];
            int[] dgSecundaria = new int[tam];
            

            Console.WriteLine("Digite os elementos da matriz nas posições [i, j] seguido de espaço. "); 
            Console.WriteLine("Apos digitar a linha aperte enter e repita o processo na proxima linha. ");
            //Este laço preenche a matriz e seleciona as diagonais.
            for (int i = 0; i < tam; i++)
            {
                string[] value = Console.ReadLine().Split(' ');

                for (int j = 0; j < tam; j++)
                {
                    mat[i, j] = int.Parse(value[j]);
                }
                //Seleciona as diagonais
                dgPricipal[i] = mat[i, i];
                dgSecundaria[i] = mat[i, (tam - 1) - i];

            }


            Console.WriteLine();
            Console.WriteLine("A matriz com as diagonais inversas são:  ");
            matAux = mat;
            //Este laço sobrescreve os valores na matrix Aux e printa na tela os valores.
            for(int i =0; i < tam; i++)
            {
                for(int j = 0; j < tam; j++)
                {
                    if( i == j)
                    {
                        matAux[i, j] = dgSecundaria[i];
                    }
                    else if(matAux[i, j] == mat[i, (tam - 1) - i])
                    {
                        matAux[i, j] = dgPricipal[i];
                    }
                    
                    Console.Write(matAux[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
