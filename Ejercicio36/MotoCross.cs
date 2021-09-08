using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class MotoCross:VehiculoDeCarrera
    {
        #region atributos y constructores
        private short cilindrada;
        public MotoCross(short numero,string escuderia):base(numero,escuderia)
        {

        }

        public MotoCross(short numero,string escuderia,short cilindrada):this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }
        
        
        #endregion

        #region propiedades
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }




        #endregion

        #region metodos

        public override string MostrarDatos()
        {
            return $"base.MostrarDatos()\nCilindrada - {this.cilindrada}";
        }


        #endregion

        #region sobrecarga de operadores

        public static bool operator ==(MotoCross a,MotoCross b)
        {
            if (((VehiculoDeCarrera)a) == ((VehiculoDeCarrera)b))
            {
                return a.cilindrada == b.cilindrada;

            }
            return false;
        }

        public static bool operator !=(MotoCross a,MotoCross b)
        {
            return !(a == b);

        }



        #endregion


    }
}
