using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        XML_Usuarios xml = new XML_Usuarios();

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
