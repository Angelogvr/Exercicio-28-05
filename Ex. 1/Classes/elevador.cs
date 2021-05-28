using System;

namespace Ex._1.Classes
{
    public abstract class elevador
    {
        public int andarAtual = 0;
        protected int andarTotal = 5;
        protected int capacidade = 10;
        public int pessoasPresentes;
        public int pessoasSair;

        public string entrar()
        {
            Console.WriteLine("Quantas pessoas desejam entrar?");
            pessoasPresentes = int.Parse(Console.ReadLine());

            if (pessoasPresentes > capacidade || pessoasPresentes < 0)
            {
                Console.WriteLine($"{pessoasPresentes} pessoas não podem entrar no elevador ao mesmo tempo, se organizem.");
                Console.WriteLine("Quantas pessoas desejam entrar?");
                pessoasPresentes = int.Parse(Console.ReadLine());
            }
            else if (pessoasPresentes <= 0)
            {
                Console.WriteLine($"{pessoasPresentes} pessoas não podem entrar no elevador.");
            }
            else
            {
                Console.WriteLine($"{pessoasPresentes} pessoas entraram.");
            }
            return "Uma pessoa entrou";
        }
        public string sair()
        {
            Console.WriteLine("Quantas pessoas desejam sair?");
            pessoasSair = int.Parse(Console.ReadLine());
            pessoasPresentes = pessoasPresentes - pessoasSair;

            if (pessoasPresentes > capacidade)
            {
                Console.WriteLine($"Como {pessoasPresentes} pessoas vão sair se isso passa do limite do elevador?");
            }
            else if (pessoasSair == 0)
            {
                Console.WriteLine($"Ninguém saiu.");
            }
            else
            {
                Console.WriteLine($"{pessoasSair} pessoas saíram.");
            }
            return "Uma pessoa saiu";
        }
        public string subir()
        {
            Console.WriteLine("Deseja subir para qual andar? (5 andares)");
            int opcaoSubir = int.Parse(Console.ReadLine().ToLower());
            int andarAtual = opcaoSubir;
            
            if (andarAtual > opcaoSubir)
            {
                Console.WriteLine($"Não é possível subir para baixo");
            }

            if (andarAtual <= 0)
            {
                Console.WriteLine("Opção Inválida.");
            }
            else if (andarAtual > andarTotal)
            {
                Console.WriteLine("Opção Inválida.");
            }
            else
            {
                Console.WriteLine($"Você está no {andarAtual}º andar");
            }


            return "O elevador subiu para o próximo andar";
        }
        public string descer()
        {
            Console.WriteLine("Deseja descer para qual andar? (5 andares)");
            int opcaoDescer = int.Parse(Console.ReadLine().ToLower());
            int andarAtual = opcaoDescer;

            if (andarAtual < 0)
            {
                Console.WriteLine("Opção Inválida.");
            }
            else if (andarAtual >= andarTotal)
            {
                Console.WriteLine("Opção Inválida.");
            }
            else
            {
                Console.WriteLine($"Você está no {andarAtual}º andar");
            }

            return "O elevador desceu para o próximo andar";
        }
    }
}