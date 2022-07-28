﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }

        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }


        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            if (!(taller.vehiculos is null))
            {
                sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
                foreach (Vehiculo v in taller.vehiculos)
                {
                    switch (tipo)
                    {
                        case ETipo.Ciclomotor:
                            if (v is Ciclomotor)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        case ETipo.SUV:
                            if (v is Suv)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        case ETipo.Sedan:
                            if (v is Sedan)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        default:
                            sb.AppendLine(v.Mostrar());
                            break;
                    }
                }

            }

            return sb.ToString();
        }

        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {

            if (!(taller.vehiculos is null) && taller.espacioDisponible > taller.vehiculos.Count)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                        return taller;
                }
                taller.vehiculos.Add(vehiculo);
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {

            if (!(taller.vehiculos is null))
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        taller.vehiculos.Remove(v);
                        return taller;
                    }
                }
            }
            return taller;
        }
    }
}
