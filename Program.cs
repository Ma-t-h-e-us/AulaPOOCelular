using System;

namespace Ex_máquina
{
    class Program
    {
        static void Main(string[] args)
        {
            celular celular1 = new celular();

            celular1.cor = "Magenta";
            celular1.modelo = "Smartphone Motorola Moto G9 Play, 64GB, 4GB RAM, Câmera Traseira Tripla, Android 10 e Processador Octa-Core";
            celular1.tamanhoTela = 6.5;
            celular1.ligar_desligar = false;
            
            bool loop2 = false;
            do {
            Console.WriteLine("Aperte L para ligar o celular");
            string seLigou = Console.ReadLine().ToLower();
           

                if (seLigou == "l")
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), celular1.cor, true);
                    celular1.ligar_desligar = celular1.Ligar();
                    Console.WriteLine($@"
Especificações do celular:
{celular1.cor}
{celular1.tamanhoTela} polegadas
{celular1.modelo}");
                    do
                    {
                        Console.WriteLine($@"
Bem vindo!

1 - Ligação
2 - Enviar mensagem
3 - Desligar");
                        string opcao = Console.ReadLine().ToLower().Substring(0, 1);
                        switch (opcao)
                        {
                            case "1":
                            case "l":
                                celular1.FazerLigacao();
                                break;

                            case "2":
                            case "e":
                                celular1.EnviarMensagem();
                                break;
                            case "3":
                            case "d":
                                celular1.ligar_desligar = celular1.Desligar();
                                break;
                            default:
                                Console.WriteLine("erro, insira outra opção!");
                                break;
                        }

                    } while (celular1.ligar_desligar == true);
                }
                else
                {
                    loop2 = true;
                }
            } while (loop2 == true);
        }
    }
}
