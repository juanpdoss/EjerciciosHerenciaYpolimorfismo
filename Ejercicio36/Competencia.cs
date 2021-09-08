using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class Competencia
    {
        #region atributos, constructores y enumerado
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipoCompetencia;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores,TipoCompetencia tipoCompetencia) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipoCompetencia = tipoCompetencia;
        }


        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }


        #endregion

        #region propiedades

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if (i < this.competidores.Count && i > -1)
                    return this.competidores.ElementAt(i);
                else
                    return null;
            
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipoCompetencia;
            }
            set
            {
                this.tipoCompetencia = value;
            }
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
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if (c.tipoCompetencia == TipoCompetencia.F1 && a is AutoF1)
            {
                foreach (AutoF1 item in c.competidores)
                {
                    if (item == ((AutoF1)a))
                    {
                        return true;
                    }

                }
                return false;


            }
            else if(c.tipoCompetencia == TipoCompetencia.MotoCross && a is MotoCross)
            {
                foreach (MotoCross item in c.competidores)
                {
                    if (item == ((MotoCross)a))
                    {
                        return true;
                    }

                }
                return false;


            }
            else
            {
                return false;
            }       

        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }


        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {

            if (c.cantidadCompetidores > c.competidores.Count)
            {             
                if(c != a)
                {
                    Random combustibleRandom = new Random();
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)combustibleRandom.Next(15, 101);
                    c.competidores.Add(a);
                    return true;
                }

            
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;

        }


        #endregion

    }

}
