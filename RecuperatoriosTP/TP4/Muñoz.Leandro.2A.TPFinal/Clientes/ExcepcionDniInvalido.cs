using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    public class ExcepcionDniInvalido: Exception
    {
        public ExcepcionDniInvalido(string mensaje) : this (null,mensaje)
        {

        }

        public ExcepcionDniInvalido(Exception inner , string mensaje) : base (mensaje,inner)
        {

        }



    }

}
