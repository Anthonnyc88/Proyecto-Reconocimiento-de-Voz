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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Admin v = new Menu_Admin();
            v.Show();
        }
    }
}
