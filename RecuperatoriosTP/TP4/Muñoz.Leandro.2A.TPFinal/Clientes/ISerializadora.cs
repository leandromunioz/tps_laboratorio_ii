using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    public interface ISerializadora<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elemento"></param>
        /// <param name="nombreArchivo"></param>
        public void Serializar(T elemento, string nombreArchivo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        public T Deserializar(string nombreArchivo);
    }
}
