using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Data.SqlClient;
namespace Emporio_motoquero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-HRTU4FN ; database=EMPORIO ; integrated security= True");
            conexion.Open();
            string user = textBox1.Text;
            string password = textBox2.Text;
            string cadena = "select nombre from trabajadores t, credencial c where t.codigo_trabajador=c.codigo_trabajador and c.usuario ='"+user+"' and c.contraseña='"+password+"'" ;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader authenticate = comando.ExecuteReader();
            if(authenticate.Read())
            {
                MessageBox.Show("INICIANDO SESION...");
                Thread.Sleep(2000);
                Form formulario = new playground(cadena);
                this.Hide();
                formulario.Show();    
    }
            else
            {
                MessageBox.Show("Usuario o clave inválida. Intente nuevamente.");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
