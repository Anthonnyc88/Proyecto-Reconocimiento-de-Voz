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
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Principal : Form
    {
        XML_Usuarios xml = new XML_Usuarios();
        Validaciones validaciones = new Validaciones();
        public static string nombreUsuario = String.Empty;

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
            if (txtCedula.Text.Length == 0 || txtNombre.Text.Length == 0 || txtEdad.Text.Length == 0 || txtContraseña.Text.Length == 0)
            {
                MessageBox.Show("Debe de Llenar todos los campos");
            }
            else
            {
                //xml._crearXml("Usuarios.xml", "Usuarios");
                xml._Añadir_Usuario(txtCedula.Text, txtNombre.Text, Convert.ToInt16(txtEdad.Text), comboSexo.SelectedItem.ToString(), txtContraseña.Text);
                MessageBox.Show("El Registro se realizo con Exito!!");
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (xml.Consulta_Login(txtCedulaLogin.Text, txtContraseñaLogin.Text))
            {
                MessageBox.Show("Usuario Registrado en el Sistema......");
                //MessageBox.Show(xml.Retorna_Nombre(Convert.ToInt16(txtCedulaLogin.Text)));
                nombreUsuario = xml.Retorna_Nombre(Convert.ToInt16(txtCedulaLogin.Text));
                this.Hide();
                Parqueo conectar = new Parqueo();
                conectar.Show();
            }
            else {
                MessageBox.Show("Usuario NO Registrado en el Sistema");
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parqueo conectar = new Parqueo();
            conectar.Show();

        }

        private void txtCedulaLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloLetras(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);
        }
    }
}
