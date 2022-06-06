using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    public class Sistema<T> where T : class
    {

        List<T> lista;

        public Sistema()
        {
            lista = new List<T>();
        }

        public List<T> Lista
        {
            get
            {
                return lista;
            }
            set
            {
                lista = value;
            }
        }

        public bool AgregarElemento(T e)
        {
            foreach (T item in lista)
            {
                if (e.Equals(item))
                {
                    return false;
                }
            }

            lista.Add(e);
            return true;

        }



        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            foreach (T item in lista)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();

        }


        public T BuscarElemento(T e)
        {
            foreach (T item in lista)
            {
                if (item.Equals(e))
                {
                    return item;
                }
            }

            return null;

        }




    }
}
