using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class AutoF1
    {

        #region atributos y constructor 
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        public AutoF1(short numero,string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;

        }

        #endregion

        #region Propiedades

        //Realizar los métodos getters y setters para cantidadCombustible, enCompetencia y
        //vueltasRestantes.

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
                if(value>0)
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
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Auto numero {this.numero}");
            sb.AppendLine($"Escuderia {this.escuderia}");
            sb.AppendLine($"Combustible {this.cantidadCombustible}");
            sb.AppendLine($"Vueltas restante {this.vueltasRestantes}");
            return sb.ToString();
        }

        #endregion

        #region sobrecarga de operadores

        public static bool operator == (AutoF1 a, AutoF1 b)
        {
            return a.numero == b.numero && a.escuderia == b.escuderia;
        }


        public static bool operator !=(AutoF1 a,AutoF1 b)
        {
            return !(a == b);
        }


        #endregion
    }
}
