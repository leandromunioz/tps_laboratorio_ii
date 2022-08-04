using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    public static class Extensora
    {
        //METODO EXTENDIDO QUE VALIDA EDAD MINIMA PARA INGRESAR AL GIMNASIO
        public static bool EsMenor(this DateTime fecha)
        {
            if (fecha.AddYears(16) > DateTime.Today)
            {
                return true;
            }
            return false;
        }
    }
}
