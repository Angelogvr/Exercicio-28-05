using System;

namespace Ex3.Classes
{
    public class MaquinaCafe
    {
        private int acucarAdc;
        private int acucarDisp = 30;

        public string fazerCafe()
        {
            if (acucarAdc <= 10)
            {
                acucarDisp = acucarDisp - 10;

            }

            return "aaa";
        }
        public void fazerCafe(int acucarAdc)
        {
            Console.WriteLine("Quer um cafézinho? Com quantas gramas de açucar? (max 30)");
            acucarAdc = int.Parse(Console.ReadLine());

            if (acucarAdc < acucarDisp)
            {
                acucarDisp = acucarDisp - acucarAdc;
                Console.WriteLine("Cafézinho feito");
            }
            else if (acucarAdc > acucarDisp)
            {
                Console.WriteLine("Não tem açucar disponível");

            }
        }
    }
}