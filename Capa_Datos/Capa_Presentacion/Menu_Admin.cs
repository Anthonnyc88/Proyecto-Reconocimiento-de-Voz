using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
            labelNombreAdmin.Text = Principal.nombreUsuario + "!!";
            this.CenterToScreen();
        }

        private void Menu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal v = new Principal();
            v.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes v = new Reportes();
            v.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
