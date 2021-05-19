using System;

namespace Ex_máquina
{
    public class celular
    {
        public string cor;
        public string modelo;
        public double tamanhoTela;
        public bool ligar_desligar;
        public bool loop1 = true;

        public bool Ligar()
        {
            ligar_desligar = true;
            return ligar_desligar;
        }
        public bool Desligar()
        {
            ligar_desligar = false;
            return ligar_desligar;
        }
        public void FazerLigacao()
        {

            do
            {
                Console.WriteLine("insira o número que deseja ligar (sem DDD)");
                int numeroCel = int.Parse(Console.ReadLine());
                if (numeroCel >= 100000000 && numeroCel <= 999999999)
                {
                    Console.WriteLine("Ligando...");
                    Console.WriteLine("Conectado");
                    Console.WriteLine("desligar[1]");
                    string desligar = Console.ReadLine().ToLower().Substring(0, 1);
                    switch (desligar)
                    {
                        case "1":
                        case "d":
                            loop1 = false;
                            break;
                        default:
                            loop1 = false;
                            break;
                }

                }
                else
                {
                    Console.WriteLine("Número inválido");
                }
            } while (loop1 == true);

        }

    public void EnviarMensagem()
    {
        Console.WriteLine(@"
Suas opções de contato são:

1 - | Ismot
2 - | Marto
3 - | Uberlei
4 - | Crivela");
        string contatoLigar = Console.ReadLine().ToLower().Substring(0, 1);
        Console.WriteLine("mensagem:");
        string mensagem = Console.ReadLine();
        switch (contatoLigar)
        {
            case "1":
            case "i":
            case "2":
            case "m":
            case "3":
            case "u":
            case "4":
            case "c":
                Console.WriteLine($@"
{mensagem}
Mensagem enviada!");
                break;
            default:
                Console.WriteLine("você não possí este contato :(");
                break;
        }
        
    }

    }
}