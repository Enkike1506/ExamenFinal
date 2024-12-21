using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using ExamenFinal.CapaModelo;

namespace ExamenFinal.CapaLogica
{
    public class Empleados
    {
        public static int AgregarEmpleados(int carne, string nombre, int edad, string fechaNacimiento, string categoria, int salario, string direccion, string telefono, string correo)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarEmpleados", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@carne", carne));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@edad", edad));
                    cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", fechaNacimiento));
                    cmd.Parameters.Add(new SqlParameter("@categoria", categoria));
                    cmd.Parameters.Add(new SqlParameter("@salario", salario));
                    cmd.Parameters.Add(new SqlParameter("@direccion", direccion));
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int BorrarEmpleados(int id)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarEmpleados", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static List<ClsEmpleado> ObtenerAsignaciones()
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            List<ClsEmpleado> empleados = new List<ClsEmpleado>();
            try
            {

                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ConsultarEmpleados", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsEmpleado Empleado = new ClsEmpleado();
                            Empleado.Id = reader.GetInt32(0);
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return empleados;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return empleados;
        }
    }
}