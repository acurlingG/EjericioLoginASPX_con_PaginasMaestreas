using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace loginupi.CapaNegocio
{
    public class Usuario_Logica : Iusuario
    {

        public int Agregar()
        {
            int retorno = 0;
            int tipo = 1;
            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Gerenciausuarios", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@opcion", tipo));
                    cmd.Parameters.Add(new SqlParameter("@id", Clsusuario.Getid()));
                    cmd.Parameters.Add(new SqlParameter("@usuario", Clsusuario.Getusuario()));
                    cmd.Parameters.Add(new SqlParameter("@clave", Clsusuario.Getclave()));

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

        public int Modifiar()
        {
            int retorno = 0;
            int tipo = 3;
            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Gerenciausuarios", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@opcion", tipo));
                    cmd.Parameters.Add(new SqlParameter("@id", Clsusuario.Getid()));
                    cmd.Parameters.Add(new SqlParameter("@usuario", Clsusuario.Getusuario()));
                    cmd.Parameters.Add(new SqlParameter("@clave", Clsusuario.Getclave()));

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
        public int Borrar()
        {
            int retorno = 0;
            int tipo = 2;
            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Gerenciausuarios", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@opcion", tipo));
                    cmd.Parameters.Add(new SqlParameter("@id", Clsusuario.Getid()));

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
        public int Modificar() {  return 0; }

        private void encriptarclave() { }
        private void desencriptar() { }

        
    }
}