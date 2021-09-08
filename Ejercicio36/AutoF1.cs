using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class AutoF1:VehiculoDeCarrera
    {
        #region atributos y constructores
        private short caballosDeFuerza;

        public AutoF1(short numero,string escuderia):base(numero,escuderia)
        {

        }

        public AutoF1(short numero,string escuderia,short caballosDeFuerza):this(numero,escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;

        }


        #endregion

        #region metodos 

        public override string MostrarDatos()
        {
            return $"{base.MostrarDatos()}\nCaballos de fuerza: {this.caballosDeFuerza}";
        }


        #endregion

        #region sobrecarga de operadores

        public static bool operator ==(AutoF1 a,AutoF1 b)
        {
            if(((VehiculoDeCarrera)a) == ((VehiculoDeCarrera)b))
            {
                return a.caballosDeFuerza == b.caballosDeFuerza;

            }
            return false;   

        }

        public static bool operator !=(AutoF1 a,AutoF1 b)
        {
            return !(a == b);
        }


        #endregion

    }
}
