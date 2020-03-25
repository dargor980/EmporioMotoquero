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

namespace Emporio_motoquero
{
    public partial class playground : Form
    {
        public playground(string buffer)
        {
            string b = buffer;
            string nombre;
            SqlConnection conexion = new SqlConnection("server=DESKTOP-HRTU4FN ; database=EMPORIO ; integrated security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand(b, conexion);
            SqlDataReader user_name = comando.ExecuteReader();
            if(user_name.Read())
            {
                
            }
            
            nombre= user_name["nombre"].ToString();
           
            InitializeComponent();
            label2.Text = nombre;

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void nuevaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consulta = new nuevaConsulta();
            consulta.Show();
        }

        private void playground_Load(object sender, EventArgs e)
        {

        }

        private void ingresarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ingresoventa = new IngresarVenta();
            ingresoventa.Show();
        }
    }
}
