using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using ExamenFinal.CapaModelo;

namespace ExamenFinal.CapaLogica
{
    public class Asignaciones
    {
        public static int AgregarAsignaciones(int empleadoId, int proyectoId, string fechaAsignacion)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarAsignaciones", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@empleadoId", empleadoId));
                    cmd.Parameters.Add(new SqlParameter("@proyectoId", proyectoId));
                    cmd.Parameters.Add(new SqlParameter("@fechaAsignacion", fechaAsignacion));

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

        public static int BorrarAsignaciones(int id)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarAsignaciones", Conn)
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

        public static List<ClsAsignacion> ObtenerAsignaciones()
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            List<ClsAsignacion> asignaciones = new List<ClsAsignacion>();
            try
            {

                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ConsultarAsignaciones", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsAsignacion asignacion = new ClsAsignacion();
                            asignacion.Id = reader.GetInt32(0);
                            asignacion.EmpleadoId = reader.GetInt32(1);
                            asignacion.ProyectoId = reader.GetInt32(2);
                            asignacion.FechaAsignacion = reader.GetString(3);
                            asignaciones.Add(asignacion);
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return asignaciones;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return asignaciones;
        }
    }
}