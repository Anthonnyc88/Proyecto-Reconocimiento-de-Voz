using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Capa_Datos;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Reportes : Form
    {
        XML_Usuarios xml = new XML_Usuarios();
        Validaciones validaciones = new Validaciones();

        public Reportes()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void Reporte1()
        {

        }

        public void Reporte2()
        {

        }

        public void Reporte3()
        {
            chart3.Palette = ChartColorPalette.Pastel;
            chart3.Titles.Add("CANTIDAD DE PERSONAS DE TIPO MASCULINO");

            Series serie = chart3.Series.Add("CANTIDAD DE HOMBRES");
            serie.Label = xml.Cantidad_Usuarios_Hombres().ToString();
            serie.Points.Add(Convert.ToDouble(xml.Cantidad_Usuarios_Hombres()));
        }

        public void Reporte4()
        {
            chart2.Palette = ChartColorPalette.Pastel;
            chart2.Titles.Add("CANTIDAD DE PERSONAS DE TIPO FEMENINO");

            Series serie = chart2.Series.Add("CANTIDAD DE MUJERES");
            serie.Label = xml.Cantidad_Usuarios_Mujeres().ToString();
            serie.Points.Add(Convert.ToDouble(xml.Cantidad_Usuarios_Mujeres()));
        }

        public void Reporte5()
        {
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("CANTIDAD DE PERSONAS MAYORES A 20 AÑOS");

            Series serie = chart1.Series.Add("PERSONAS MAYORES A 20 AÑOS");
            serie.Label = xml.Cantidad_Usuarios_Mayores().ToString();
            serie.Points.Add(Convert.ToDouble(xml.Cantidad_Usuarios_Mayores()));
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            Reporte1();
            Reporte2();
            Reporte3();
            Reporte4();
            Reporte5();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Admin v = new Menu_Admin();
            v.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hombres Sistema: " + xml.Cantidad_Usuarios_Hombres());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mujeres Sistema: " + xml.Cantidad_Usuarios_Mujeres());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personas Mayores de 20 años en el Sistema: " + xml.Cantidad_Usuarios_Mayores());
        }

      
    }
}
