using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace examenpractico
{
    public partial class Form1 : Form
    {
        private string SqlConnection = "Server=localhost;Port=3306;Database=exapractico1;Uid=root;Pwd= ;";
        private SerialPort ArduinoPort;
        private ToolTip toolTip;

        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM6";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            toolTip = new ToolTip();

            btEncender.Click += btEncender_Click;
            btApagar.Click += btApagar_Click;

            tbNombre.TextChanged += tbNombre_TextChanged;
            tbFecha.TextChanged += tbFecha_TextChanged;
        }
        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (!validarNombre(tbNombre.Text))
            {
                tbNombre.BackColor = Color.LightCoral;
                toolTip.SetToolTip(tbNombre, "El nombre debe tener al menos 3 caracteres.");
            }
            else
            {
                tbNombre.BackColor = Color.Gray;
                toolTip.SetToolTip(tbNombre, string.Empty);
            }
        }
        private void tbFecha_TextChanged(object sender, EventArgs e)
        {
            if (!validarFecha(tbFecha.Text))
            {
                tbFecha.BackColor = Color.LightCoral;
                toolTip.SetToolTip(tbFecha, "Por favor ingresa una fecha válida (formato: yyyy/MM/dd).");
            }
            else
            {
                tbFecha.BackColor = Color.Gray;
                toolTip.SetToolTip(tbFecha, string.Empty);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private bool validarNombre(string nombre)
        {
            return !string.IsNullOrEmpty(nombre) && nombre.Length >= 3;
        }
        private bool validarFecha(string fecha)
        {
            return DateTime.TryParse(fecha, out _);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string fecha = tbFecha.Text;
            if (!validarNombre(nombre))
            {
                MessageBox.Show("Por favor ingresa un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!validarFecha(fecha))
            {
                MessageBox.Show("Por favor ingresa una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float lbCel = 25.0f;
            float lbFar = lbCel * 9 / 5 + 32;

            InsertarRegistro(nombre, fecha, lbCel, lbFar);
            string datos = $"Nombre: {nombre}\r\nFecha: {fecha}";

            MessageBox.Show("Datos guardados con éxito: \n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InsertarRegistro(string nombre, string fecha, float lbCel, float lbFar)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(SqlConnection))

                {
                    conexion.Open();
                    string insertQuery = "INSERT INTO datos (Nombre_Usuario, Fecha, Temp_Celsius, Temp_Fahrenheit) VALUES (@Nombre_Usuario, @Fecha, @Temp_Celsius, @Temp_Fahrenheit)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre_Usuario", nombre);

                        // Convertir la fecha a DateTime
                        DateTime fechaDateTime;
                        if (DateTime.TryParseExact(fecha, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaDateTime))
                        {
                            cmd.Parameters.AddWithValue("@Fecha", fechaDateTime);
                        }
                        else
                        {
                            MessageBox.Show("El formato de fecha no es válido. Por favor usa el formato yyyy/MM/dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir si la fecha no es válida
                        }

                        cmd.Parameters.AddWithValue("@Temp_Celsius", lbCel);
                        cmd.Parameters.AddWithValue("@Temp_Fahrenheit", lbFar);

                        cmd.ExecuteNonQuery();
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ArduinoPort != null && ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
            base.OnFormClosing(e);
        }

        private void lbFar_Click(object sender, EventArgs e)
        {

        }
    }
}
