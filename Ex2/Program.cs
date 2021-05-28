using System;
using Ex2.Classes;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ataque a = new Ataque(); 
            Defesa d = new Defesa(); 
            Meio m = new Meio();

                    a.imprimir();
                    a.calcular();
                    if (a.posicao == "a")
                    {
                    a.aposentar();        
                    }else if (a.posicao == "d")
                    {
                        d.aposentar();
                    }else if (a.posicao == "m")
                    {
                        m.aposentar();
                    }
            
        }
    }
}
