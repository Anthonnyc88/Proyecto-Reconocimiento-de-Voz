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
    public partial class Principal : Form
    {
        XML_Usuarios xml = new XML_Usuarios();

        public Principal()
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
            //falta la validacion de que se llenes todos los datos
            if (txtCedula.TextLength != 0 || txtNombre.TextLength != 0 || txtEdad.TextLength != 0 || txtContraseña.TextLength != 0)
            {
                xml._Añadir_Usuario(txtCedula.Text,txtNombre.Text,Convert.ToInt16(txtEdad.Text),comboSexo.SelectedItem.ToString(),txtContraseña.Text);
                MessageBox.Show("El Registro se realizo con Exito!!");
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtContraseña.Text = "";
            }
            else { MessageBox.Show("Debe de Llenar todos los campos"); }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (xml.Consulta_Login(txtCedula, txtContraseña))
            {
                MessageBox.Show("Usuario Registrado en el Sistema");
            }
            else {
                MessageBox.Show("Usuario no Registrado en el Sistema");
            }
        }
    }
}
