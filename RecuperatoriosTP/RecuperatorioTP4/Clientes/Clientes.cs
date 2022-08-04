using System;
using System.Text;

namespace Gimnasio

{
    public class Clientes : Persona , IToString
    {
        DateTime fechaPago;
        

        public Clientes()
        {

        }

        public Clientes(string nombre, string apellido, string dni, DateTime fechaNac, string direc, DateTime fechaPago) : base(nombre, apellido, dni, fechaNac, direc)

        {
            this.fechaPago = fechaPago;
        }

        public DateTime FechaPago
        {

            get
            {
                return fechaPago;
            }
            set
            {
                fechaPago = value;
            }
        }

        /// <summary>
        /// Método que permite mostrar datos. Con el método base en la clase Persona y con polimorfismo aplicado para que se añada la fech de pago a los datos a mostrar.
        /// </summary>
        /// <returns> </returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"            {fechaPago.ToShortDateString()}\n");

            return sb.ToString();

        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool DniExistente ( Sistema<Clientes> lista , string dni)
        {
            foreach ( Clientes cliente in lista.Lista)
            {
                if(cliente.Dni == dni)
                {
                    return true;
                }
            }

            return false;

        }

    }
}
