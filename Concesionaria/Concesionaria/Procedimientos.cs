using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Concesionaria
{
    public partial class Procedimientos : Form
    {
        SqlConnection Conexion;
        public Procedimientos()
        {
            InitializeComponent();
            Conexion = new SqlConnection("Server=192.168.56.102 ; Database=Concesionaria ; User ID=AdminConcesionaria ; Password=1234 ;");
        }

        private void btnProc1_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string nroMotor = tbxNroMotor.Text;
            DateTime fechaRT = dtpFecha.Value;
            SqlCommand comando = new SqlCommand("ActualizarFechaRevisiónTécnica", Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("NroMotor", nroMotor);
            comando.Parameters.AddWithValue("NuevaFecha", fechaRT);
            bool condicion = Convert.ToBoolean(comando.ExecuteNonQuery());
            if (condicion)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Se actualizó correctamente la fecha de la revisión técnica.");
            }
            else
            {
                MessageBox.Show("Hubo un error en la actualización de la fecha de la revisión técnica.");
            }
            Conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string tipoDNI = tbxTipoDNI.Text;
            int nroDNI = int.Parse(tbxNroDNI.Text);
            string direccion = tbxDirecion.Text;
            short codigoPostal = short.Parse(tbxCP.Text);
            SqlCommand comando = new SqlCommand("ActualizarCiudadDirecciónPersona", Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("CP", codigoPostal);
            comando.Parameters.AddWithValue("Direccion", direccion);
            comando.Parameters.AddWithValue("TipoDNI", tipoDNI);
            comando.Parameters.AddWithValue("NroDNI", nroDNI);
            bool condicion = Convert.ToBoolean(comando.ExecuteNonQuery());
            if (condicion)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Se actualizó correctamente la ciudad y la dirección de la persona.");
            }
            else
            {
                MessageBox.Show("Hubo un error en la actualización de la ciudad y la dirección de la persona.");
            }
            Conexion.Close();
        }
    }
}
