using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class Competencia
    {
        #region atributos y constructores
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas,short cantidadCompetidores):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }


        #endregion

        #region metodos 
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores - {this.competidores.Count}");
            sb.AppendLine($"Cantidad de vueltas - {this.cantidadVueltas}");

            return sb.ToString();
        }



        #endregion

        #region sobrecarga de operadores

        public static bool operator == (Competencia c,AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if(item == a)
                {
                    return true;
                }

            }
            return false;

        }

        public static bool operator !=(Competencia c,AutoF1 a)
        {
            return !(c == a);
        }


        public static bool operator +(Competencia c,AutoF1 a)
        {
          
            if(c.cantidadCompetidores > c.competidores.Count)
            {
                if(c!=a)
                {
                    Random combustibleRandom = new Random();

                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)combustibleRandom.Next(15,101);
                    c.competidores.Add(a);
                    return true;
                }


            }
            return false;
        }

        public static bool operator -(Competencia c,AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;   

        }


        #endregion

    }
}
