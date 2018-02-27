using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Menu : Form
    {
        public static String usuario;
        public static int id;
        public static String nombre_apellido;
        public Menu(DataRow user)
        {
            InitializeComponent();
            usuario = user["docPersona"].ToString();
            id = int.Parse(user["idPersona"].ToString());
            nombre_apellido = user["Nombres"].ToString() + " " + user["Apellidos"].ToString();
            timer1.Enabled = true;
            label9.Text = nombre_apellido;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Vender().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new RegistrarUsuario().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Sucursal().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Login log = new Login();
            log.txtUser.Text = "";
            log.txtPass.Text = "";
        }
    }
}
