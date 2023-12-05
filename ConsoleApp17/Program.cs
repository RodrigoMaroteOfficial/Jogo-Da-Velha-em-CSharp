////versao 1.1 (adaptada)
//class Program


//{
//    class Jogo
//    {
//        public Jogo()
//        {
//            valor1 = valor2 = valor3 = valor4 = valor5 = valor6 =
//            valor7 = valor8 = valor9 = "-";
//        }
//        public string valor1 { get; set; }
//        public string valor2 { get; set; }
//        public string valor3 { get; set; }
//        public string valor4 { get; set; }
//        public string valor5 { get; set; }
//        public string valor6 { get; set; }
//        public string valor7 { get; set; }
//        public string valor8 { get; set; }
//        public string valor9 { get; set; }
//    }
//    class Jogador
//    {
//        public string jogadorEscreve { get; set; }
//        public int[] pontos = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//        public bool ChecarVitoria(int[] posicoes)
//        {
//            if (posicoes[0] + posicoes[1] + posicoes[2] == 15 ||
//            posicoes[3] + posicoes[4] + posicoes[5] == 15 ||
//            posicoes[6] + posicoes[7] + posicoes[8] == 15 ||
//            posicoes[0] + posicoes[3] + posicoes[6] == 15 ||
//            posicoes[1] + posicoes[4] + posicoes[7] == 15 ||
//            posicoes[2] + posicoes[5] + posicoes[8] == 15 ||
//            posicoes[0] + posicoes[4] + posicoes[8] == 15 ||
//            posicoes[2] + posicoes[4] + posicoes[6] == 15)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//    class Planilha
//    {
//        public int[] posicoes = new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8 };
//        public string[] hifens = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
//        public void Sobscrever(int posicao, int jogadorAtual)
//        {
//            if (jogadorAtual == 1)
//            {
//                this.hifens[posicao - 1] = "X";


//            }
//            else
//            {
//                this.hifens[posicao - 1] = "O";
//            }
//        }
//    }
//    static void Main(string[] args)
//    {
//        Jogador jogador1 = new Jogador();
//        Jogador jogador2 = new Jogador();
//        Planilha objetoTabuleiro = new Planilha();
//        bool empate = false;
//        int jogadorAtual = 1; //dessa vez 1 e 2 pois representa J1 e J2, ao invez de 0 e 1.
//    int posicao;
//        int rodada = 0; //usado pra verificar se foi empate na ultima rodada
//    bool linhaFeita = false; //feito pra garantir que se alguem ganhar na ultima rodada, nao vai aparecer "empate" na tela.
//string vencedor = "";
//        bool podePassar = true;
//        Console.WriteLine("Digite os Nomes dos Jogadores.");
//        Console.Write("Jogador 1: ");
//        jogador1.jogadorEscreve = Console.ReadLine();
//        Console.Write("Jogador 2: ");
//        jogador2.jogadorEscreve = Console.ReadLine();
//        do
//        {
//            Console.Clear();
//            Console.WriteLine($"{objetoTabuleiro.hifens[0]} | { objetoTabuleiro.hifens[1]} | {objetoTabuleiro.hifens[2]}");
//        Console.WriteLine("---------");
//            Console.WriteLine($"{objetoTabuleiro.hifens[3]} | { objetoTabuleiro.hifens[4]} | {objetoTabuleiro.hifens[5]}");
//        Console.WriteLine("---------");
//            Console.WriteLine("{0} | {1} | {2}", objetoTabuleiro.hifens[6], objetoTabuleiro.hifens[7], objetoTabuleiro.hifens[8]);
//            Console.WriteLine();
//            Console.WriteLine();
//            if (jogadorAtual == 1)
//            {
//                do

//                {
//                    podePassar = true;
//                    Console.Write($"{jogador1.jogadorEscreve}, Digite um Numero de 1 a 9: ");
//                    posicao = int.Parse(Console.ReadLine());
//                    while (posicao <= 0 || posicao >= 10)
//                    {
//                        podePassar = false;
//                        Console.WriteLine("ERRO: NUMERO NAO ESTA ENTRE 1 E 9");
//                        posicao = int.Parse(Console.ReadLine());
//                    }
//                    if ((objetoTabuleiro.hifens[posicao - 1] != "-"))
//                    {
//                        podePassar = false;
//                        Console.WriteLine("ERRO: NUMERO JA FOI DIGITADO");
//                    }
//                } while (podePassar == false);
//                jogador1.pontos[posicao - 1] = objetoTabuleiro.posicoes
//                [posicao - 1];
//                objetoTabuleiro.Sobscrever(posicao, jogadorAtual);
//                rodada++;
//            }
//            else
//            {
//                do
//                {
//                    podePassar = true;
//                    Console.Write($"{jogador2.jogadorEscreve}, Digite um Numero de 1 a 9: ");
//                    posicao = int.Parse(Console.ReadLine());
//                    while (posicao <= 0 || posicao >= 10)
//                    {
//                        podePassar = false;
//                        Console.WriteLine("ERRO: NUMERO NAO ESTA ENTRE 1 E 9");
//                        posicao = int.Parse(Console.ReadLine());
//                    }
//                    if ((objetoTabuleiro.hifens[posicao - 1] != "-"))
//                    {
//                        podePassar = false;
//                        Console.WriteLine("ERRO: NUMERO JA FOI DIGITADO");
//                    }
//                } while (podePassar == false);
//                jogador2.pontos[posicao - 1] = objetoTabuleiro.posicoes
//                [posicao - 1];
//                objetoTabuleiro.Sobscrever(posicao, jogadorAtual);
//                rodada++;
//            }


//            if (jogadorAtual == 1) // Proximo Jogador
//            {
//                jogadorAtual = 2;
//            }
//            else
//            {
//                jogadorAtual = 1;
//            }
//            if (jogador1.ChecarVitoria(jogador1.pontos)) //checa vitoria do jogador 1
//{
//                linhaFeita = true;
//                vencedor = jogador1.jogadorEscreve;
//            }
//            if (jogador2.ChecarVitoria(jogador2.pontos)) //checa vitoria do jogador 2
//{
//                linhaFeita = true;
//                vencedor = jogador2.jogadorEscreve;
//            }
//            if (rodada == 9 && linhaFeita == false) //checa empate
//            {
//                empate = true;
//            }
//        } while (linhaFeita == false && empate == false); //enquanto alguem nao vencer, ou nao der empate, o jogo continua
//Console.Clear();
//        Console.WriteLine($"{objetoTabuleiro.hifens[0]} | { objetoTabuleiro.hifens[1]} | { objetoTabuleiro.hifens[2]}");
//Console.WriteLine("---------");
//        Console.WriteLine($"{objetoTabuleiro.hifens[3]} | { objetoTabuleiro.hifens[4]} | { objetoTabuleiro.hifens[5]}");
//Console.WriteLine("---------");
//        Console.WriteLine("{0} | {1} | {2}", objetoTabuleiro.hifens[6], objetoTabuleiro.hifens[7], objetoTabuleiro.hifens[8]);
//        Console.WriteLine();
//        Console.WriteLine();
//        if (empate == false)
//        {
//            Console.WriteLine($"{vencedor} venceu");
//        }
//        else
//        {
//            Console.WriteLine("Empate");
//        }

//        Console.ReadKey();
//    }
//}















//Versao 1.0 (original)
class program
{
    class jogo
    {
        public jogo()
        {
            valor1 = valor2 = valor3 = valor4 = valor5 = valor6 =
            valor7 = valor8 = valor9 = "-";
        }
        public string valor1 { get; set; }
        public string valor2 { get; set; }
        public string valor3 { get; set; }
        public string valor4 { get; set; }
        public string valor5 { get; set; }
        public string valor6 { get; set; }
        public string valor7 { get; set; }
        public string valor8 { get; set; }
        public string valor9 { get; set; }
    }
    static void Main(string[] args)
    {
        jogo jogada = new jogo();
        int quemJoga = 0; 
        int digitada;
        string vencedor = "";
        bool linhaFeita = false;
        bool podePassar;
        int[] jaFoi = new int[9];
        int rodada = 0;
        bool empate = false;
        do
        {
            Console.Write(jogada.valor1);
            Console.Write(jogada.valor2);
            Console.Write(jogada.valor3);
            Console.WriteLine();
            Console.Write(jogada.valor4);
            Console.Write(jogada.valor5);
            Console.Write(jogada.valor6);
            Console.WriteLine();
            Console.Write(jogada.valor7);
            Console.Write(jogada.valor8);
            Console.Write(jogada.valor9);
            Console.WriteLine();
            if (quemJoga == 0) //vez do jogador 1
            {
                quemJoga = 1;

                Console.WriteLine();
                do //comeca a verificar se o numero digitado ja tem um X ou O, ou se nao esta entre 1 e 9
                {
                    podePassar = true;
                    Console.WriteLine("Jogador 1, Digite um numero de 1 a 9");
                    digitada = int.Parse(Console.ReadLine());
                    while (digitada <= 0 || digitada >= 10)
                    {
                        Console.WriteLine("Digite apenas numeros entre 1 e 9!");
                        digitada = int.Parse(Console.ReadLine());
                    }
                    
                    for (int i = 0; i != 8; i++) //for que vai checar o array pra ver se o numero digitado ja esta dentro dele. claramente na rodada zero nao tera nada ainda
                    {
                        if (digitada == jaFoi[i])
                        {
                            podePassar = false;
                            Console.WriteLine("Digite um numero que ainda nao foi digitado!");
                        }
                    }
                } while (podePassar == false);
                jaFoi[rodada] = digitada; //o numero que foi digitado (ex: 5), entra dentro do array
                rodada++;
                switch (digitada)
                {
                    case 1:
                        jogada.valor1 = "X";
                        break;
                    case 2:
                        jogada.valor2 = "X";
                        break;
                    case 3:
                        jogada.valor3 = "X";
                        break;
                    case 4:
                        jogada.valor4 = "X";
                        break;
                    case 5:
                        jogada.valor5 = "X";
                        break;
                    case 6:
                        jogada.valor6 = "X";
                        break;
                    case 7:
                        jogada.valor7 = "X";
                        break;

                    case 8:
                        jogada.valor8 = "X";
                        break;
                    case 9:
                        jogada.valor9 = "X";
                        break;
                }
            }
            else //vez do jogador 2
            {
                quemJoga = 0;
                Console.WriteLine();
                do
                {
                    podePassar = true;
                    Console.WriteLine("Jogador 2, Digite um numero de 1 a 9");
                    digitada = int.Parse(Console.ReadLine());
                    while (digitada <= 0 || digitada >= 10)
                    {
                        Console.WriteLine("Digite apenas numeros entre 1 e 9!");
                        digitada = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i != 8; i++)
                    {
                        if (digitada == jaFoi[i])
                        {
                            podePassar = false;
                            Console.WriteLine("Digite um numero que ainda nao foi digitado!");
                        }
                    }
                } while (podePassar == false);
                jaFoi[rodada] = digitada;
                rodada++;
                switch (digitada)
                {
                    case 1:
                        jogada.valor1 = "O";
                        break;
                    case 2:
                        jogada.valor2 = "O";
                        break;
                    case 3:
                        jogada.valor3 = "O";
                        break;
                    case 4:
                        jogada.valor4 = "O";

                        break;
                    case 5:
                        jogada.valor5 = "O";
                        break;
                    case 6:
                        jogada.valor6 = "O";
                        break;
                    case 7:
                        jogada.valor7 = "O";
                        break;
                    case 8:
                        jogada.valor8 = "O";
                        break;
                    case 9:
                        jogada.valor9 = "O";
                        break;
                }
            }
            Console.Clear();
            if (jogada.valor1 == "X" && jogada.valor2 == "X" &&
            jogada.valor3 == "X" || jogada.valor4 == "X" &&
            jogada.valor5 == "X" && jogada.valor6 == "X" ||
            jogada.valor7 == "X" && jogada.valor8 == "X" &&
            jogada.valor9 == "X" || jogada.valor1 == "X" &&
            jogada.valor4 == "X" && jogada.valor7 == "X" ||
            jogada.valor2 == "X" && jogada.valor5 == "X" &&
            jogada.valor8 == "X" || jogada.valor3 == "X" &&
            jogada.valor6 == "X" && jogada.valor9 == "X" ||
            jogada.valor1 == "X" && jogada.valor5 == "X" &&
            jogada.valor9 == "X" || jogada.valor3 == "X" &&
            jogada.valor5 == "X" && jogada.valor7 == "X")
            {
                linhaFeita = true;
                vencedor = "Jogador 1";
            }
            if (jogada.valor1 == "O" && jogada.valor2 == "O" &&
            jogada.valor3 == "O" || jogada.valor4 == "O" &&
            jogada.valor5 == "O" && jogada.valor6 == "O" ||
            jogada.valor7 == "O" && jogada.valor8 == "O" &&
            jogada.valor9 == "O" || jogada.valor1 == "O" &&
            jogada.valor4 == "O" && jogada.valor7 == "O" ||
            jogada.valor2 == "O" && jogada.valor5 == "O" &&
            jogada.valor8 == "O" || jogada.valor3 == "O" &&
            jogada.valor6 == "O" && jogada.valor9 == "O" ||
            jogada.valor1 == "O" && jogada.valor5 == "O" &&
            jogada.valor9 == "O" || jogada.valor3 == "O" &&
            jogada.valor5 == "O" && jogada.valor7 == "O")
            {
                linhaFeita = true;
                vencedor = "Jogador 2";
            }


            if (rodada >= 9)
            {
                empate = true;
            }
        } while (linhaFeita == false && empate == false);
        if (linhaFeita == true)
        {
            Console.WriteLine("{0} venceu! Resultado:", vencedor);
        }
        else //so vai chegar aqui caso chegue na ultima rodada e a variavel linha feita nunca vire true, isso evita ganhar na ultima rodada, e mesmo assim mostrar empate
        {
            Console.WriteLine("Empate");
        }
        Console.Write(jogada.valor1);
        Console.Write(jogada.valor2);
        Console.Write(jogada.valor3);
        Console.WriteLine();
        Console.Write(jogada.valor4);
        Console.Write(jogada.valor5);
        Console.Write(jogada.valor6);
        Console.WriteLine();
        Console.Write(jogada.valor7);
        Console.Write(jogada.valor8);
        Console.Write(jogada.valor9);
        Console.WriteLine();
        Console.ReadKey();
    }
}













