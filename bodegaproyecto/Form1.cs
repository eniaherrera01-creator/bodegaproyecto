using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace bodegaproyecto
{
    public partial class Form1 : Form
    {

        private string servidor = "";
        private string rutaConfig = "configuracion.txt";


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                servidor = ObtenerServidorSQL();


                if (servidor == null)
                {
                    Application.Exit();
                    return;
                }


                VerificarBaseDeDatos();


                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    MessageBox.Show(
                        "Conexión exitosa con Sistema_Bodega",
                        "Correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    "Error al conectar:\n" + ex.Message
                );

            }
        }





        private string ObtenerServidorSQL()
        {

            string nombrePC = Environment.MachineName;


            string[] servidores =
            {
                nombrePC + "\\SQLEXPRESS",
                nombrePC + "\\MSSQLSERVER",
                nombrePC,
                "localhost"
            };


            foreach (string servidor in servidores)
            {

                try
                {

                    string cadena =
                    $"Server={servidor};Integrated Security=True;TrustServerCertificate=True;";


                    using (SqlConnection con = new SqlConnection(cadena))
                    {

                        con.Open();

                        return cadena;

                    }

                }
                catch
                {

                }

            }


            MessageBox.Show(
                "No se encontró SQL Server"
            );


            return null;

        }






        private void VerificarBaseDeDatos()
        {

            try
            {

                if (!File.Exists(rutaConfig))
                {

                    CrearBaseDeDatos();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }







        private void CrearBaseDeDatos()
        {

            MessageBox.Show(
                "Debe crear la base de datos Sistema_Bodega"
            );

        }








        private string CalcularSHA256(string texto)
        {

            using (SHA256 sha = SHA256.Create())
            {

                byte[] bytes =
                sha.ComputeHash(
                    Encoding.UTF8.GetBytes(texto)
                );


                StringBuilder sb = new StringBuilder();


                foreach (byte b in bytes)
                {

                    sb.Append(
                        b.ToString("x2")
                    );

                }


                return sb.ToString();

            }

        }








        private void button3_Click(object sender, EventArgs e)
        {

            string usuario =
                txtusuario.Text.Trim();


            string clave =
                CalcularSHA256(
                    txtcontra.Text.Trim()
                );



            if (usuario == "" || clave == "")
            {

                MessageBox.Show(
                    "Ingrese usuario y contraseña"
                );


                return;

            }



            try
            {


                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {


                    string sql =
                    @"SELECT rol 
                    FROM Usuario
                    WHERE usuario=@usuario
                    AND Contraseña=@clave";



                    SqlCommand cmd =
                    new SqlCommand(sql, con);



                    cmd.Parameters.AddWithValue(
                        "@usuario",
                        usuario
                    );


                    cmd.Parameters.AddWithValue(
                        "@clave",
                        clave
                    );




                    object resultado =
                    cmd.ExecuteScalar();





                    if (resultado != null)
                    {


                        menu frm = new menu();


                        menu.UsuarioActual = usuario;


                        menu.RolUsuario = resultado.ToString();



                        this.Hide();


                        frm.ShowDialog();


                        txtusuario.Clear();
                        txtcontra.Clear();


                        this.Show();


                    }
                    else
                    {


                        MessageBox.Show(
                            "Usuario o contraseña incorrectos"
                        );


                    }


                }


            }
            catch (Exception ex)
            {


                MessageBox.Show(
                    "Error:\n" + ex.Message
                );


            }


        }







        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}