using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        #region atributos, enumerados y propiedades

        protected Franja franjaHoraria;

        public Provincial(Franja franja,Llamada llamada):this(llamada.NroOrigen,franja,llamada.Duracion,llamada.NroDestino)
        {
            
        }

        public Provincial(string origen,Franja franja,float duracion,string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = franja;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();

            }
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }


        #endregion


        private float CalcularCosto()
        {
            float resultado = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    resultado = (float)(base.duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    resultado= (float)(base.duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    resultado = (float)(base.duracion * 0.66);
                    break;
                default:
                    break;
            }

            return resultado;

        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();        
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("franja horaria: " + this.franjaHoraria);
            sb.AppendLine("Costo llamada:" + this.CostoLlamada);

            return sb.ToString();
        }


    }
}
