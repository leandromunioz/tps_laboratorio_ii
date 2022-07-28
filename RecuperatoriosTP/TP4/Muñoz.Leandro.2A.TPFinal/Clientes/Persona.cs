using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    public class Persona 
    {

        protected string nombre;
        protected string apellido;
        protected string dni;
        protected DateTime fechaNacimiento;
        protected string direccion;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, string dni, DateTime fechaNac, string direc)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNac;
            this.direccion = direc;

        }


        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }

        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }




        /// <summary>
        /// Método que permite mostrar los datos de una persona.
        /// </summary>
        /// <returns> </returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{nombre} {apellido}                      {dni}              {fechaNacimiento.ToShortDateString()}                   {direccion}  ");

            return sb.ToString();

        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public override bool Equals(object obj)
        {
            return this == (Persona)obj;
        }

        public static bool operator ==(Persona persona1, Persona persona2)
        {
            if (persona1.Dni == persona2.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator !=(Persona persona1, Persona persona2)
        {
            return !(persona1 == persona2);
        }


    }
}
