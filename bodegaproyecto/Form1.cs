using System.Security.Cryptography;
using System.Text;


using Azure;
using iTextSharp.text.pdf.codec.wmf;
using Microsoft.Data.SqlClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography; // HASH
using System.Text; // HASH
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class Form1 : Form
    {

        //servidor: almacena la cadena de conexión al servidor SQL.
        //conexionDB: gestiona la conexión a la base de datos.
        // rutaConfig: archivo donde se guarda el estado de SQL y la base de datos.
        private string servidor = "";
        private ConexionBD conexionDB = new ConexionBD();
        private string rutaConfig = "configuracion.txt";

        public Form1()
        {
            InitializeComponent();
        }



        private string ObtenerServidorSQL()
        {
            string nombrePC = Environment.MachineName;
            string[] posiblesInstancias = { "SQLEXPRESS", "MSSQLSERVER", "SQL2019", "ENIAGOMEZ" };

            foreach (string instancia in posiblesInstancias)
            {
                string servidorPrueba = $"Server={nombrePC}\\{instancia};Integrated Security=True;TrustServerCertificate=True;";
                try
                {
                    using (SqlConnection con = new SqlConnection(servidorPrueba))
                    {
                        con.Open();
                        return servidorPrueba;
                    }
                }
                catch
                {
                    continue;
                }
            }

            string servidorDefault = $"Server={nombrePC};Integrated Security=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection con = new SqlConnection(servidorDefault))
                {
                    con.Open();
                    return servidorDefault;
                }
            }
            catch
            {
                MessageBox.Show("❌ No se pudo conectar a SQL Server en este equipo.\nVerifique que esté instalado y ejecutándose.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void VerificarConfiguracion()
        {
            try
            {
                if (File.Exists(rutaConfig))
                {
                    string[] lineas = File.ReadAllLines(rutaConfig);
                    bool tieneSQL = Array.Exists(lineas, l => l.Contains("SQL=SI"));
                    bool tieneBD = Array.Exists(lineas, l => l.Contains("BD=SI"));

                    if (!tieneSQL)
                    {
                        MessageBox.Show("Debe instalar SQL Server antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }

                    if (!tieneBD)
                    {
                        DialogResult crearBD = MessageBox.Show("¿Desea crear la base de datos automáticamente?",
                            "Crear Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (crearBD == DialogResult.Yes)
                            CrearBaseDeDatos();
                        else
                        {
                            MessageBox.Show("No se puede continuar sin la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    // Si no existe el archivo, verificar directamente la BD
                    VerificarBaseDeDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la verificación: " + ex.Message);
            }
        }

        private void VerificarBaseDeDatos()
        {
            try
            {
                string cadenaMaster = servidor + "Database=master;";
                using (SqlConnection con = new SqlConnection(cadenaMaster))
                {
                    con.Open();
                    string verificarBD = "SELECT COUNT(*) FROM sys.databases WHERE name = 'Sistema_Bodega'";
                    SqlCommand cmd = new SqlCommand(verificarBD, con);
                    int existe = (int)cmd.ExecuteScalar();

                    if (existe == 0)
                    {
                        DialogResult resultado = MessageBox.Show(
                            "No se encontró la base de datos Sistema_Bodega.\n¿Desea crearla ahora?",
                            "Base de datos no encontrada",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            CrearBaseDeDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se puede continuar sin la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        GuardarConfiguracion("SQL=SI", "BD=SI");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la base de datos: " + ex.Message);
            }
        }

        //Guarda en el archivo configuracion.txt:Estado del SQL Server, Estado de la base de datos.
        private void GuardarConfiguracion(string sql, string bd)
        {
            try
            {
                File.WriteAllLines(rutaConfig, new string[] { sql, bd });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar configuración: " + ex.Message);
            }
        }


        //Este método realiza automáticamente
        private void CrearBaseDeDatos()
        {
            try
            {
                string cadenaMaster = servidor + "Database=master;";
                using (SqlConnection con = new SqlConnection(cadenaMaster))
                {
                    con.Open();

                    // Dividir en comandos separados porque CREATE DATABASE debe ir solo
                    string crearDB = "CREATE DATABASE Sistema_Bodega;";
                    SqlCommand cmdDB = new SqlCommand(crearDB, con);
                    cmdDB.ExecuteNonQuery();

                    // Ahora conectar a la nueva base de datos
                    con.ChangeDatabase("Sistema_Bodega");

                    //Creación de todas las tablas:
                    //Todas con claves primarias y foráneas correctamente definidas.
                    string script = @"


CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    Contraseña VARCHAR(100) NOT NULL,
    rol VARCHAR(50) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1,

);


CREATE TABLE Categoria (
    id_categoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_Categoria VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(200),
    Estado BIT NOT NULL DEFAULT 1
);

CREATE TABLE Proveedor (
    id_proveedor INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20),
    Correo VARCHAR(100),
    Direccion VARCHAR(200),
    Estado BIT NOT NULL DEFAULT 1
);


CREATE TABLE Producto (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_Producto VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(200),
    Precio_Compra DECIMAL(10,2) NOT NULL,
    Precio_Venta DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
    fecha_vencimiento DATE NULL,
    impuesto DECIMAL(10,2) NOT NULL DEFAULT 0,
    id_categoria INT NOT NULL,
    Estado BIT NOT NULL DEFAULT 1,

    CONSTRAINT FK_Producto_Categoria
    FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);


CREATE TABLE Compra (
    id_compra INT IDENTITY(1,1) PRIMARY KEY,
    fecha_compra DATE NOT NULL,
    id_proveedor INT NOT NULL,

    CONSTRAINT FK_Compra_Proveedor
    FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_proveedor)
);


CREATE TABLE Detalle_Compra (
    id_DetalleCompra INT IDENTITY(1,1) PRIMARY KEY,
    Cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    id_compra INT NOT NULL,
    id_producto INT NOT NULL,

    CONSTRAINT FK_DetalleCompra_Compra
    FOREIGN KEY (id_compra) REFERENCES Compra(id_compra),

    CONSTRAINT FK_DetalleCompra_Producto
    FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);


CREATE TABLE Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
	DNI VARCHAR(20) NOT NULL UNIQUE,
    Nombre VARCHAR(100) NOT NULL,
    RTN VARCHAR(20) NULL,
    Telefono VARCHAR(20) NULL,
    Correo VARCHAR(100) NULL,
    Direccion VARCHAR(200) NULL,
    Fecha_Registro DATETIME NOT NULL DEFAULT GETDATE(),
    Estado BIT NOT NULL DEFAULT 1
);

INSERT INTO Cliente
(
DNI,Nombre,RTN,Telefono,Correo,Direccion,Estado)VALUES
(
'0000000000000',
'CLIENTE GENERICO',
'00000000000000',
'N/A',
'N/A',
'VENTA AL CONTADO',
1
);

CREATE TABLE Venta (
    id_venta INT IDENTITY(1,1) PRIMARY KEY,
    Fecha_Venta DATETIME NOT NULL DEFAULT GETDATE(),
    metodo_pago VARCHAR(50) NOT NULL,
    id_usuario INT NOT NULL,
    id_cliente INT NOT NULL DEFAULT 1,

    FOREIGN KEY (id_usuario)
    REFERENCES Usuario(id_usuario),

    FOREIGN KEY (id_cliente)
    REFERENCES Cliente(id_cliente)
);

CREATE TABLE Detalle_Venta (
    id_detalleventa INT IDENTITY(1,1) PRIMARY KEY,
    Cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    id_venta INT NOT NULL,
    id_producto INT NOT NULL,

    CONSTRAINT FK_DetalleVenta_Venta
    FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),

    CONSTRAINT FK_DetalleVenta_Producto
    FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);


INSERT INTO Usuario (Nombre, usuario, Contraseña, rol, Estado)
VALUES
('Juan Perez', 'jperez',
 CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','1234'),2),
 'Administrador', 1),

('Maria Lopez', 'mlopez',
 CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','1234'),2),
 'Cajero', 1),

('Carlos Ramos', 'cramos',
 CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','1234'),2),
 'Supervisor', 1),

('Ana Torres', 'atorres',
 CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','1234'),2),
 'Vendedor', 1),

('Luis Mejia', 'lmejia',
 CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','1234'),2),
 'Bodega', 1),

('Fernanda Herrera', 'fherrera',
 CONVERT(VARCHAR(64), HASHBYTES('SHA2_256','12345'),2),
 'Administrador', 1);


INSERT INTO Categoria (Nombre_Categoria, Descripcion)
VALUES
('Bebidas', 'Productos liquidos'),
('Lacteos', 'Productos derivados de leche'),
('Snacks', 'Botanas y frituras'),
('Limpieza', 'Productos de aseo'),
('Panaderia', 'Productos de pan');

INSERT INTO Proveedor (Nombre, Telefono, Correo, Direccion)
VALUES
('Distribuidora Norte', '9999-1111', 'norte@gmail.com', 'Tegucigalpa'),
('Alimentos SA', '9999-2222', 'alimentos@gmail.com', 'San Pedro Sula'),
('Honduras Market', '9999-3333', 'market@gmail.com', 'Choluteca'),
('Productos Centro', '9999-4444', 'centro@gmail.com', 'La Ceiba'),
('Distribuidora Sur', '9999-5555', 'sur@gmail.com', 'Comayagua');


INSERT INTO Producto
(Nombre_Producto, Descripcion, Precio_Compra, Precio_Venta, Stock,
fecha_vencimiento, impuesto, id_categoria)
VALUES
('Coca Cola', 'Bebida gaseosa', 18.00, 25.00, 100, '2026-12-31', 0, 1),
('Leche Sula', 'Leche entera', 22.00, 30.00, 80, '2026-10-15', 0, 2),
('Doritos', 'Snack de maiz', 12.00, 18.00, 60, '2026-09-20', 0, 3),
('Cloro', 'Producto de limpieza', 35.00, 50.00, 40, NULL, 0, 4),
('Pan Integral', 'Pan saludable', 28.00, 40.00, 30, '2026-08-10', 0, 5);
";

                    // Cambio en el insert de la base de datos

                    SqlCommand cmd = new SqlCommand(script, con);
                    cmd.ExecuteNonQuery();

                    GuardarConfiguracion("SQL=SI", "BD=SI");

                    MessageBox.Show("✅ Base de datos Sistema_Bodega creada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al crear la base de datos: " + ex.Message);
            }
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // PASO 1: Detectar el servidor SQL automáticamente
                servidor = ObtenerServidorSQL();

                if (servidor == null)
                {
                    Application.Exit();
                    return;
                }

                // PASO 2: Verificar si existe la base de datos
                VerificarBaseDeDatos();

                // PASO 3: Intentar conectar a la base de datos
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    MessageBox.Show("✅ Conexión exitosa con la base de datos Sistema_Bodega.",
                        "Conexión verificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar con la base de datos:\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.ActiveControl = txtusuario;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTituloForm_Click(object sender, EventArgs e)
        {

        }


        // PARTE DEL HASH
        private string CalcularSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtusuario.Text.Trim();
            string contra = CalcularSHA256(txtcontra.Text.Trim()); // HASH

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT rol FROM Usuario WHERE usuario=@usuario AND Contraseña=@clave";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@usuario", nombre);
                    cmd.Parameters.AddWithValue("@clave", contra);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        menu.RolUsuario = resultado.ToString();
                        menu.UsuarioActual = nombre;

                        menu frm = new menu();

                        this.Hide();

                        frm.ShowDialog();

                        // Cuando el menú se cierre,
                        // volvemos a mostrar el login.

                        txtusuario.Clear();
                        txtcontra.Clear();

                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}