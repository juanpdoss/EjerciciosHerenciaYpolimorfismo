using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        #region atributos y propiedades
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region constructores

        public Local(Llamada llamada,float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

        }
        
        public Local(string origen,float duracion,string destino,float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }



        #endregion

        #region metodos

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("costo: " + this.costo);
         
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {                 
             return obj is Local;       
        }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }



        #endregion
    }
}
