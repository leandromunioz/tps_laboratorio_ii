using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    public static class ClientesDB
    {

        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static ClientesDB()
        {
            cadenaConexion = @"Data Source=.\;Initial Catalog=ClientesDB;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;

        }


        public static void Guardar(Clientes clientes)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO CLIENTES_GYM (DNI,NOMBRE,APELLIDO,FECHA_NAC,DIRECCION,FECHA_PAGO) VALUES (@dni,@nombre,@apellido,@fechaNac,@direc,@fechaPago)";

                comando.Parameters.AddWithValue("@dni", clientes.Dni);
                comando.Parameters.AddWithValue("@nombre", clientes.Nombre);
                comando.Parameters.AddWithValue("@apellido", clientes.Apellido);
                comando.Parameters.AddWithValue("@fechaNac", clientes.FechaNacimiento);
                comando.Parameters.AddWithValue("@direc", clientes.Direccion);
                comando.Parameters.AddWithValue("@fechaPago", clientes.FechaPago);


                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

        }





        public static Sistema<Clientes> Leer()
        {
            Sistema<Clientes> clientes = new Sistema<Clientes>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM CLIENTES_GYM";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    clientes.AgregarElemento(new Clientes((dataReader["NOMBRE"]).ToString(), (dataReader["APELLIDO"]).ToString(), (dataReader["DNI"]).ToString(), Convert.ToDateTime(dataReader["FECHA_NAC"]), (dataReader["DIRECCION"]).ToString(), Convert.ToDateTime(dataReader["FECHA_PAGO"])));


                }

                dataReader.Close();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return clientes;


        }


        public static void Eliminar(int dni)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM CLIENTES_GYM WHERE DNI = {dni}";
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
        }


        public static void Modificar(Clientes clientes)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE CLIENTES_GYM SET DNI = @dni, NOMBRE = @nombre, APELLIDO = @apellido,  FECHA_NAC = @fechaNac, DIRECCION = @direc , FECHA_PAGO = @fechaPago WHERE DNI = {clientes.Dni}";

                comando.Parameters.AddWithValue("@dni", clientes.Dni);
                comando.Parameters.AddWithValue("@nombre", clientes.Nombre);
                comando.Parameters.AddWithValue("@apellido", clientes.Apellido);
                comando.Parameters.AddWithValue("@fechaNac", clientes.FechaNacimiento);
                comando.Parameters.AddWithValue("@direc", clientes.Direccion);
                comando.Parameters.AddWithValue("@fechaPago", clientes.FechaPago);

                comando.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }



    }

}
