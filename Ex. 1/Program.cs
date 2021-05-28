using System;
using Ex._1.Classes;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcaoElv = 0;

            Console.WriteLine(@"
Qual elevador deseja utilizar?
1 - Social
2 - Serviço
");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                elevadorSocial elvSc = new elevadorSocial();
                elvSc.entrar();
                elvSc.subir();

                do
                {
                    

                Console.WriteLine(@"
O que deseja fazer agora?
1 - Sair do elevador
2 - Descer
3 - Subir");
                opcaoElv = int.Parse(Console.ReadLine());

                switch (opcaoElv)
                {
                    case 1:
                    elvSc.sair();
                        break;
                    case 2:
                    elvSc.descer();
                        break;
                    case 3:
                    elvSc.subir();
                        break;
                    default:
                        break;
                }
                
                } while (elvSc.pessoasPresentes == 0);
            }
        }
    }
}
