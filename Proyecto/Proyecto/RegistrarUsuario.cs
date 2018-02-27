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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
            String sql = "SELECT docPersona, Nombres, Apellidos, Rol FROM persona";
            DataTable table = Conexion.Data(sql);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
