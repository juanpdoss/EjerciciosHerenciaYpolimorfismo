using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class VehiculoDeCarrera
    {       
        #region atributos y constructor 
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;

        }

        #endregion

        #region Propiedades

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }

        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }



        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }




        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                if (value > 0)
                    this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }


        #endregion

        #region metodos 
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Vehiculo numero {this.numero}");
            sb.AppendLine($"Escuderia {this.escuderia}");
            sb.AppendLine($"Combustible {this.cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes {this.vueltasRestantes}");
            return sb.ToString();
        }

        #endregion

        #region sobrecarga de operadores

        public static bool operator ==(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            return a.numero == b.numero && a.escuderia == b.escuderia;
        }


        public static bool operator !=(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            return !(a == b);
        }


        #endregion
    }




}
