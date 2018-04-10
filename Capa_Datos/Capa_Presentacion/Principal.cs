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

            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea Salir", "Salir del Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
                Close();
            }
           
                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //falta la validacion de que se llenes todos los datos
            if (txtCedula.Text.Length == 0 || txtNombre.Text.Length == 0 || txtEdadX.Text.Length == 0 || txtContraseña.Text.Length == 0|| comboSexo.SelectedItem.ToString().Length==0)
            {
                MessageBox.Show("Debe de Llenar todos los campos");
            }
            else
            {
                //string tU = "Administrador";
                string tU = "Cliente";            
                xml._Añadir_Usuario(txtCedula.Text, txtNombre.Text, txtEdadX.Text, comboSexo.SelectedItem.ToString(), txtContraseña.Text,tU);              
                MessageBox.Show("El Registro se realizo con Exito!!");
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtEdadX.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (xml.Consulta_Login(txtCedulaLogin.Text, txtContraseñaLogin.Text) == "Cliente")
            {

                nombreUsuario = xml.Retorna_Nombre(Convert.ToInt16(txtCedulaLogin.Text));
                this.Hide();
                Parqueo conectar = new Parqueo();
                conectar.Show();
            }
            else if (xml.Consulta_Login(txtCedulaLogin.Text, txtContraseñaLogin.Text) == "Administrador") {

                this.Hide();
                Menu_Admin mA = new Menu_Admin();
                mA.Show();
            }
            else {
                MessageBox.Show("Usuario NO Registrado en el Sistema");
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //xml._crearXml("Usuarios.xml","Usuarios");
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hombres Sistema: "+xml.Cantidad_Usuarios_Hombres());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mujeres Sistema: " + xml.Cantidad_Usuarios_Mujeres());
        }

        private void txtContraseñaLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (xml.Consulta_Login(txtCedulaLogin.Text, txtContraseñaLogin.Text) == "Cliente")
                {

                    nombreUsuario = xml.Retorna_Nombre(Convert.ToInt16(txtCedulaLogin.Text));
                    this.Hide();
                    Parqueo conectar = new Parqueo();
                    conectar.Show();
                }
                else if (xml.Consulta_Login(txtCedulaLogin.Text, txtContraseñaLogin.Text) == "Administrador")
                {

                    this.Hide();
                    Menu_Admin mA = new Menu_Admin();
                    mA.Show();
                }
                else
                {
                    MessageBox.Show("Usuario NO Registrado en el Sistema");
                }
            }
        }
    }
}
