using System;
using System.Threading;

namespace _Testes_2
{
    public static class Global
    {
        public static char[] caracteres = new char[62];
        public static int contador, contador2 = 0, contador3, contador4, contador5, contador6, contador7, contador8, incrementador, qtd_tentativas;
        public static string senha, tentativa;

        public static void PreencherVetor()
        {
            // Preenche o vetor "letras" com dígitos (0 a 9) e letras maiúsculas (A - Z) e minúsculas (a - z) 
            incrementador = 48;
            for (contador = 0; contador < 75; contador++)
            {
                if (incrementador >= 48 && incrementador <= 57 || incrementador >= 65 && incrementador <= 90 || incrementador >= 97 && incrementador <= 122)
                {
                    caracteres[contador2] = (char)incrementador;
                    contador2++;
                }
                incrementador++;
            }
        }
        public static void StartBruteForce()
        {
            // Realiza uma combinações entre todos os caracteres possíveis (que estão dentro do vetor "caracteres") e...
            // ... compara com a senha digitada até que ambas sejam iguais;
            for (contador = 0; contador < 62; contador++)
            {
                for (contador2 = 0; contador2 < 62; contador2++)
                {
                    for (contador3 = 0; contador3 < 62; contador3++)
                    {
                        for (contador4 = 0; contador4 < 62; contador4++)
                        {
                            for (contador5 = 0; contador5 < 62; contador5++)
                            {
                                for (contador6 = 0; contador6 < 62; contador6++)
                                {
                                    for (contador7 = 0; contador7 < 62; contador7++)
                                    {
                                        for (contador8 = 0; contador8 < 62; contador8++)
                                        {
                                            tentativa = "" + Global.caracteres[contador]
                                                + Global.caracteres[contador2]
                                                + Global.caracteres[contador3]
                                                + Global.caracteres[contador4]
                                                + Global.caracteres[contador5]
                                                + Global.caracteres[contador6]
                                                + Global.caracteres[contador7]
                                                + Global.caracteres[contador8];
                                            Console.WriteLine(tentativa);
                                            qtd_tentativas++;
                                            if (tentativa == senha)
                                            {
                                                contador = 62;
                                                contador2 = 62;
                                                contador3 = 62;
                                                contador4 = 62;
                                                contador5 = 62;
                                                contador6 = 62;
                                                contador7 = 62;
                                                contador8 = 62;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Global.PreencherVetor();

            // Pede para o usuário digitar uma senha
            Console.Write("Digite uma senha (obrigatóriamente com 8 caracteres) somente com letras (maiúsculas ou minúsculas) e números: ");
            Global.senha = Console.ReadLine();

            Thread BruteForce = new Thread(Global.StartBruteForce);
            BruteForce.Start();

            // Apresenta para o usuário qual foi a senha que ele digitou e a quantidade de tentativas que foram necessárias para...
            //... quebra-la.
            Console.WriteLine("Sua senha é: " + Global.tentativa);
            Console.WriteLine("Foram necessárias " + Global.qtd_tentativas + " tentativas para quebrar sua senha");
        }

    }
}
