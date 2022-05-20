using System;

namespace _Testes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] caracteres = new char[62];
            int contador, contador2 = 0, contador3, contador4, contador5, contador6, contador7, contador8, incrementador;

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

            Console.Write("Digite uma senha (obrigatóriamente com 8 caracteres) somente com letras (maiúsculas ou minúsculas) e números: ");
            string senha = Console.ReadLine();
            string tentativa = "";
            int qtd_tentativas = 0;

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
                                            tentativa = "" + caracteres[contador]
                                                + caracteres[contador2]
                                                + caracteres[contador3]
                                                + caracteres[contador4]
                                                + caracteres[contador5]
                                                + caracteres[contador6]
                                                + caracteres[contador7]
                                                + caracteres[contador8];
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
            Console.WriteLine("Sua senha é: " + tentativa);
            Console.WriteLine("Foram necessárias " + qtd_tentativas + " tentativas para quebrar sua senha");
        }
    }
}
