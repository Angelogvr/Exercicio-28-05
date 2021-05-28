using System;

namespace Ex2.Classes
{
    public abstract class Jogador
    {
        private string nome;
        public string posicao;
        private int ano;
        private int idade;
        private int TempRest;
        private string nacionalidade;
        private double altura;
        private int peso;

        public string imprimir()
        {
            Console.WriteLine("\nDigite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("\nQual posição você joga? (A, D, M)");
            posicao = Console.ReadLine().ToLower();

            Console.WriteLine("\nDigite seu ano de nascimento:");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite sua nacionalidade:");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("\nDigite sua altura:");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite seu peso:");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados impressos!");

            return "Impresso";
        }

        public string calcular()
        {
            int anoAtual = DateTime.Now.Year;
            idade = (anoAtual - ano);
            return $"{idade}";
        }

        public string aposentar()
        {
            if (posicao == "m")
            {
                TempRest = 38 - idade;
                if (TempRest > 0)
                {
                    Console.WriteLine($"\nResta {TempRest} anos para você se aposentar!");
                }
                else if (TempRest == 0)
                {
                    Console.WriteLine($"\nVocê tem {idade}, você pode se aposentar!");
                }
                else if (TempRest < 0)
                {
                    Console.WriteLine($"\nVocê está aposentado, com {idade} anos!");
                }
            }
            if (posicao == "a")
            {
                TempRest = 35 - idade;
                if (TempRest > 0)
                {
                    Console.WriteLine($"\nResta {TempRest} anos para você se aposentar!");
                }
                else if (TempRest == 0)
                {
                    Console.WriteLine($"\nVocê pode se aposentar!");
                }
                else if (TempRest < 0)
                {
                    Console.WriteLine($"\nVocê está aposentado!");
                }
            }
            if (posicao == "d")
            {
                TempRest = 40 - idade;
                if (TempRest > 0)
                {
                    Console.WriteLine($"\nResta {TempRest} anos para você se aposentar!");
                }
                else if (TempRest == 0)
                {
                    Console.WriteLine($"\nVocê pode se aposentar!");
                }
                else if (TempRest < 0)
                {
                    Console.WriteLine($"\nVocê está aposentado!");
                }
            }
            
            return $"{TempRest}";

        }
    }
}