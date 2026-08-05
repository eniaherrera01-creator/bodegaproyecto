using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;



namespace bodegaproyecto
{
  
    
    public static class Bitacora
    {
        public static void Registrar(String modulo, String accion, String descripcion)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string sql = @"INSERT INTO Bitacora 
                        (fecha, usuario, modulo, accion, descripcion)
                        VALUES 
                        (GETDATE(), @usuario, @modulo, @accion, @descripcion)";

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@usuario", menu.UsuarioActual);
                    cmd.Parameters.AddWithValue("@modulo", modulo);
                    cmd.Parameters.AddWithValue("@accion", accion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error bitacora: " + ex.Message);
            }
        }
    }
}
