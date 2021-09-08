using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region atributos y props
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);

            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }

        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
            
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region constructores

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;

        }
        #endregion

        #region metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
           
            float acumLocal = 0;
            float acumProvincial = 0;

            foreach (var item in this.listaDeLlamadas)
            {
                if(item is Local)
                {
                    acumLocal += ((Local)item).CostoLlamada;

                }else if(item is Provincial)
                {
                    acumProvincial += ((Provincial)item).CostoLlamada;
                }
                
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                             return acumLocal;


                case Llamada.TipoLlamada.Provincial:
                             return acumProvincial;
                            
                case Llamada.TipoLlamada.Todas:
                             return acumProvincial + acumLocal;


                default:
                            return acumProvincial + acumLocal;
                   
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Razon social: {this.razonSocial} \n");
            sb.AppendLine("cantidad de llmadas: " + this.listaDeLlamadas.Count);
            sb.AppendLine("Ganancia total: " + this.GananciasPorTotal);
            sb.AppendLine("Ganancia por llamadas locales: " + this.GananciasPorLocal);
            sb.AppendLine("Ganancia por llamadas provinciales: " + this.GananciasPorProvincial);
            sb.AppendLine("detalle de las llamadas realizadas: ");
            foreach (var item in this.listaDeLlamadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {

        }


        public static bool operator ==(Centralita a,Llamada b)
        {
            bool estaIncluida = false;

            foreach (var item in a.Llamadas)
            {
                if (item == b)
                {
                    estaIncluida = true;
                    break;
                }

            }

            return estaIncluida;
        }

        public static bool operator !=(Centralita a,Llamada b)
        {
            return !(a == b);
        }


        public static Centralita operator +(Centralita a,Llamada b)
        {
            if(a!=b)  
            {
                a.listaDeLlamadas.Add(b);
            }
            return a;
        }




        public void OrdenarLlamadas()
        {

            this.Llamadas.Sort(Llamada.Ordenar);

        }

        #endregion
    }
}
