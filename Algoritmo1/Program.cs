using System;
using System.Collections.Specialized;
using System.Text;

namespace Algoritmo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 3 - Jogo da forca

            int maxTentativas = 10;
            string palavra = "DESENVOLVEDOR";
            int qtdeCaracteres = palavra.Length;
            string segredo = "";
            int letrasAcertadas = 0;

            for (int i = 0; i < qtdeCaracteres; i++)
            {
                segredo = segredo + "_ ";
            }

            string letra = "";

            for (int i = 0; i < maxTentativas; i++)
            {
                if (letrasAcertadas == palavra.Length)
                {
                    Console.WriteLine("Parábens! Você ganhou!");
                    break;
                }

                Console.WriteLine(segredo);
                Console.WriteLine("Informe uma letra:");
                letra = Console.ReadLine();
                letra = letra.ToUpper();

                if (letra.Length == 1)
                {
                    int qtdeEspacos = 0;

                    for (int l = 0; l < qtdeCaracteres; l++)
                    {
                        string letter = palavra.Substring(l, 1);

                        if (l != 0)
                            qtdeEspacos++;

                        if (letter == letra)
                        {
                            letrasAcertadas++;

                            int indexSubString;

                            if (l == 0)
                                indexSubString = l;
                            else
                                indexSubString =  l + qtdeEspacos;

                            StringBuilder sb = new StringBuilder(segredo);
                            sb[indexSubString] = Convert.ToChar(letter);
                            segredo = sb.ToString();
                        }
                    }
                }
                else
                {
                    if (letra.ToLower() == palavra.ToLower())
                    {
                        letrasAcertadas = palavra.Length;
                        Console.WriteLine("Parábens! Você ganhou!");
                        break;
                    }
                }
            }

            if (letrasAcertadas != palavra.Length)
            {
                Console.WriteLine("Você perdeu! Não foi desta vez!");
            }




            //Exerício 2 - Tempo de viagem
            //Console.WriteLine("Digite a distância (Km):");
            //double distancia = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite a velocidade (Km/H):");
            //double velocidade = Convert.ToDouble(Console.ReadLine());

            //double tempo = distancia / velocidade;

            //Console.WriteLine($"Você chegará ao seu destino em {tempo}hrs");


            //Exercício 1 - Nota do aluno
            //Console.WriteLine("DIGITE A PRIMEIRA NOTA: ");
            //double nota1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("DIGITE A SEGUNDA NOTA: ");
            //double nota2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("DIGITE A TERCEIRA NOTA: ");
            //double nota3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("DIGITE A QUARTA NOTA: ");
            //double nota4 = Convert.ToDouble(Console.ReadLine());

            //double media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Console.WriteLine(media);

            //if (media <= 6.9)
            //{
            //    Console.WriteLine($"A MEDIA DO ALUNO FOI: {media}");
            //    Console.WriteLine(" - ALUNO REPROVADO ");
            //}

            //if (media >= 7)
            //{
            //    Console.WriteLine($"A MEDIA DO ALUNO FOI: {media}");
            //    Console.WriteLine(" - ALUNO APROVADO ");
            //}
        }
    }
}
