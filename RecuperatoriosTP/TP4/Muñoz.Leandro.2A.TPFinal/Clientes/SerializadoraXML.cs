using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gimnasio
{
    public class SerializadoraXML<T> : ISerializadora<T> where T : class
    {
        static string ruta;

        static SerializadoraXML()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializados\ArchivosXML";
        }

        public void Serializar(T elemento, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"\Serializadora-" + nombreArchivo + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, elemento);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Deserializar(string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"\Serializadora-{nombreArchivo}.xml";
            T elemento = null;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    elemento = (T)xmlSerializer.Deserialize(sr);
                }

                return elemento;
            }
            catch (Exception)
            {
                throw new FileNotFoundException("Fatal error. Archivo no encontrado.");
            }
        }
    }


}
