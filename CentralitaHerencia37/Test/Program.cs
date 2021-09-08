using System;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            Local l5 = new Local("ahre", 23, "ahree", 12);
            Local l6 = new Local("ahree", 23, "ahreee", 12);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            c +=l1;
            c += l2;
            c += l3;
            c += l4;
            c += l1;
            c += l2;
            c += l3;
            c += l4;
            c += l5;
            c += l5;
            

            //c += l1;
            //c += l1;


            //c += l1;
            //c += l1;


            c.OrdenarLlamadas();


            Console.WriteLine(c.ToString());
           
        }
    }
}
