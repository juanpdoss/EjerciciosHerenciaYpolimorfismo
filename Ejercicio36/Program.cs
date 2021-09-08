using System;

namespace Ejercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1(23, "we", 550);
            AutoF1 auto2 = new AutoF1(23, "wea", 550);
            MotoCross moto1 = new MotoCross(24, "jeje", 350);
            MotoCross moto2 = new MotoCross(24, "jeje", 350);
            AutoF1 auto3 = new AutoF1(15, "SUPER", 700);

            Competencia compe = new Competencia(90, 2, Competencia.TipoCompetencia.F1);

            if(compe + auto3)
            {
                Console.WriteLine("se agrego auto numero: " + auto3.Numero);
            }
            if (compe + auto3)
            {
                //no deberia imprimir por pantlla (auto3 repetido)
                Console.WriteLine("se agrego auto numero: " + auto3.Numero);
            }
            if (compe + auto1)
            {
                Console.WriteLine("se agrego auto numero: " + auto1.Numero);
            }
            if (compe + auto2)
            {
                //no deberia imprimir por pantalla, limite de competidores alcanzado
                Console.WriteLine("se agrego auto numero: " + auto2.Numero);
            }
            if (compe + moto1)
            {
                //no deberia imprimir por pantalla
                Console.WriteLine("se agrego auto numero: " + moto1.Numero);
            }


        }
    }
}
