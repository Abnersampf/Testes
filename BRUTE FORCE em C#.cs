using System;
using System.Diagnostics;

namespace _Testes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, contador2 = 1, contador3, contador4, contador5, contador6, contador7, contador8, incrementador, qtd_tentativas = 0;
            string senha = "", tentativa = "", processo = "s";
            string[] caracteres = new string[63];
            var cronometro = new Stopwatch();

            incrementador = 48;
            caracteres[0] = "";
            for (contador = 0; contador < 76; contador++)
            {
                if (incrementador >= 48 && incrementador <= 57 || incrementador >= 65 && incrementador <= 90 || incrementador >= 97 && incrementador <= 122)
                {
                    caracteres[contador2] = (char)incrementador + "";
                    contador2++;
                }
                incrementador++;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=====================================================");
            Console.WriteLine("|     |_\\ |¯] | | ¯T¯ [_¯  [¯¯ |¯¯| |¯] |¯¯ [_¯     |");
            Console.WriteLine("|     |_/ |¯\\ |_|  |  [__  |¯¯ |__| |¯\\ |__ [__     |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("|             REQUISITOS OBRIGATÓRIOS:              |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| - Utilizar apenas letras maiúsculas e/ou...       |");
            Console.WriteLine("| ...minúsculas e/ou números;                       |");
            Console.WriteLine("| - Máximo de 8 caracteres.                         |");
            Console.WriteLine("-----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Write("| - Digite uma senha: ");
                senha = Console.ReadLine();

                if (senha.Length > 8)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|       /\\ \\  / ¯|¯ |_¯ |¯¯|  |     |");
                    Console.WriteLine("|      /¯¯\\ \\/  _|_ __| |__|  °     |");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|         Senha muito longa !       |");
                    Console.WriteLine("|          Tente novamente          |");
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("|");
                    Console.WriteLine("| - Deseja ver o processo de força bruta ?");
                    Console.Write("| [s - sim | n - não]: ");
                    processo = Console.ReadLine();
                }
                if (senha.Length <= 8)
                {
                    if (processo == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Quebrando a senha...");
                    }
                    cronometro.Start();
                    for (contador = 0; contador < 63; contador++)
                    {
                        for (contador2 = 0; contador2 < 63; contador2++)
                        {
                            for (contador3 = 0; contador3 < 63; contador3++)
                            {
                                for (contador4 = 0; contador4 < 63; contador4++)
                                {
                                    for (contador5 = 0; contador5 < 63; contador5++)
                                    {
                                        for (contador6 = 0; contador6 < 63; contador6++)
                                        {
                                            for (contador7 = 0; contador7 < 63; contador7++)
                                            {
                                                for (contador8 = 0; contador8 < 63; contador8++)
                                                {
                                                    tentativa = "" + caracteres[contador]
                                                        + caracteres[contador2]
                                                        + caracteres[contador3]
                                                        + caracteres[contador4]
                                                        + caracteres[contador5]
                                                        + caracteres[contador6]
                                                        + caracteres[contador7]
                                                        + caracteres[contador8];
                                                    qtd_tentativas++;
                                                    if (processo == "s")
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine(tentativa);
                                                    }
                                                    if (tentativa == senha)
                                                    {
                                                        contador = 63;
                                                        contador2 = 63;
                                                        contador3 = 63;
                                                        contador4 = 63;
                                                        contador5 = 63;
                                                        contador6 = 63;
                                                        contador7 = 63;
                                                        contador8 = 63;
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    cronometro.Stop();
                    TimeSpan ts = cronometro.Elapsed;
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("|                               RELATÓRIO                                  |");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.Write("| - Sua senha é: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(tentativa);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("| - Foram necessárias " + qtd_tentativas + " tentativas para quebrar sua senha");
                    Console.WriteLine("| - Tempo decorrido: {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    Console.WriteLine("----------------------------------------------------------------------------");
                }
            } while (senha.Length > 8);
        }
    }
}
