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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            String sql = "SELECT i.NumRef NumRef, i.Nombre Nombre, i.Marca Marca, SUM(s.Cantidad) Cantidad FROM " +
                "item i INNER JOIN stock s ON i.idItem = s.Item_id WHERE s.Concepto = 'Entrada'";
            DataTable table = Conexion.Data(sql);
            dataGridView1.DataSource = table;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
