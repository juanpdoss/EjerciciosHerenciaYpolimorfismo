using System;
using System.Text;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        #region propiedades, atributos y enumerado
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public abstract float CostoLlamada { get; }

        #endregion

        #region constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion constructor

        #region metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("duracion: " + this.duracion);
            sb.AppendLine("destino: " + this.nroDestino);
            sb.AppendLine("origen: " + this.nroOrigen);


            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            if(llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else if(llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }
            else
            {
                return 0;
            }


        }


        public static int Ordenar(Llamada llamada1,Llamada llamada2)
        {
            if(llamada1.duracion == llamada2.duracion)
            {
                return 0;

            }else if(llamada1.duracion>llamada2.duracion)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        public static bool operator ==(Llamada a,Llamada b)
        {
             if(a.Equals(b))
             {
                if(a.nroDestino == b.nroDestino && a.nroOrigen == b.nroOrigen)
                {
                    return true;
                }

             }

            return false;

        }

        public static bool operator !=(Llamada a,Llamada b)
        {
            return (a == b);
        }


        #endregion


    }
}
