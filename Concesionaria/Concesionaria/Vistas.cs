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
    public partial class Vistas : Form
    {
        SqlConnection Conexion;
        public Vistas()
        {
            InitializeComponent();
            Conexion = new SqlConnection("Server=192.168.56.102 ; Database=Concesionaria ; User ID=AdminConcesionaria ; Password=1234 ;");
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string sqlConsulta = "SELECT TOP 5 * FROM VistaModelosVendidos ORDER BY CantidadVendidos DESC";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlConsulta, Conexion);
            DataTable tablaDatos = new DataTable();
            dataAdapter.Fill(tablaDatos);
            grillaAutos.DataSource = tablaDatos;
            Conexion.Close();
        }

        
    }
}
