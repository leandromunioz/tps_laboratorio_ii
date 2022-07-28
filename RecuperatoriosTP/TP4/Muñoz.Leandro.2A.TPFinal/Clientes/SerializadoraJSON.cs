using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gimnasio
{

    public class SerializadoraJSON<T> : ISerializadora<T> where T : class
    {
        static string ruta;

        static SerializadoraJSON()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializados\ArchivosJSON";
        }

        public void Serializar(T elemento, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"\Serializadora-" + nombreArchivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string elementoJSON = JsonSerializer.Serialize(elemento);
                File.WriteAllText(rutaCompleta, elementoJSON);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Deserializar(string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"\Serializadora-{nombreArchivo}.json";
            T elemento = null;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string elementoJson = File.ReadAllText(rutaCompleta);
                elemento = JsonSerializer.Deserialize<T>(elementoJson);
                

                return elemento;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
