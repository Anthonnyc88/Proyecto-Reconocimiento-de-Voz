﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;


namespace Capa_Presentacion
{
    public partial class Parqueo : Form
    {

        public string mensaje;
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();

        public Parqueo()
        {
            InitializeComponent();
            this.CenterToScreen();
            labelNombreUsuario.Text = Principal.nombreUsuario;
            //serialPort1.Open();

            //Puerto
           // serialPort1.PortName = "COM3";
            //serialPort1.BaudRate = 9600;
           // serialPort1.Open();


        }

        private void Parqueo_Load(object sender, EventArgs e)
        {
            Carrito.Visible = false;
            Carrito2.Visible = false;
            Motocicleta.Visible = false;

            if (serialPort1.IsOpen) serialPort1.Close();


           






        }

       

        public void Reconocimiento(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Equals("auto"))
            {
                Carrito.Visible = true;
            }
            else if (e.Result.Text.Equals("carro"))
            {
                Carrito2.Visible = true;
            }
            else if (e.Result.Text.Equals("salir"))
            {
                Application.Exit();
            }


        }

       
        private void btnParqueo_Click(object sender, EventArgs e)
        {

            try
            {
                escucha.SetInputToDefaultAudioDevice();

                //Capta las palabras
                escucha.LoadGrammar(new DictationGrammar());
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Lector);
                escucha.RecognizeAsync(RecognizeMode.Multiple);
                escucha.AudioLevelUpdated += Nivel_Audio;


            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se puede abrir el boton tantas veces");
            }
        }


        public void Lector(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                txtPalabras.Text = palabra.Text;

                if (palabra.Text.Equals("izquierda"))
                {
                    Carrito.Location = new Point(Carrito.Location.X - 20, Carrito.Location.Y);
                    Carrito2.Location = new Point(Carrito2.Location.X - 20, Carrito2.Location.Y);
                    Motocicleta.Location = new Point(Motocicleta.Location.X - 20, Motocicleta.Location.Y);

                }
                else if  (palabra.Text.Equals("siniestra"))
                {
                    Carrito.Location = new Point(Carrito.Location.X - 20, Carrito.Location.Y);
                    Carrito2.Location = new Point(Carrito2.Location.X - 20, Carrito2.Location.Y);
                    Motocicleta.Location = new Point(Motocicleta.Location.X - 20, Motocicleta.Location.Y);
                }
                else if (palabra.Text.Equals("derecha")) {
                    Carrito.Location = new Point(Carrito.Location.X + 20, Carrito.Location.Y);
                    Carrito2.Location = new Point(Carrito2.Location.X + 20, Carrito2.Location.Y);
                    Motocicleta.Location = new Point(Motocicleta.Location.X + 20, Motocicleta.Location.Y);

                }
                else if (palabra.Text.Equals("arriba"))
                {
                    Carrito.Location = new Point(Carrito.Location.X , Carrito.Location.Y -20);
                    Carrito2.Location = new Point(Carrito2.Location.X, Carrito2.Location.Y - 20);
                    Motocicleta.Location = new Point(Motocicleta.Location.X, Motocicleta.Location.Y - 20);
                }

                else if (palabra.Text.Equals("subir"))
                {
                    Carrito.Location = new Point(Carrito.Location.X, Carrito.Location.Y - 20);
                    Carrito2.Location = new Point(Carrito2.Location.X, Carrito2.Location.Y - 20);
                    Motocicleta.Location = new Point(Motocicleta.Location.X, Motocicleta.Location.Y - 20);

                }
                else if (palabra.Text.Equals("abajo"))
                {
                    Carrito.Location = new Point(Carrito.Location.X, Carrito.Location.Y + 20);
                    Carrito2.Location = new Point(Carrito2.Location.X, Carrito2.Location.Y + 20);
                    Motocicleta.Location = new Point(Motocicleta.Location.X, Motocicleta.Location.Y + 20);
                }

                else if (palabra.Text.Equals("bajar"))
                {
                    Carrito.Location = new Point(Carrito.Location.X, Carrito.Location.Y + 20);
                    Carrito2.Location = new Point(Carrito2.Location.X, Carrito2.Location.Y + 20);
                    Motocicleta.Location = new Point(Motocicleta.Location.X, Motocicleta.Location.Y + 20);

                }

            }
        }

        public void Nivel_Audio( object sender , AudioLevelUpdatedEventArgs e)
        {
            int audio = e.AudioLevel;
            Barrita.Value = audio;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea Salir de la Aplicacion", "Salir del Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                
                this.Hide();
                Principal a = new Principal();
                a.Show();
            }

            
           
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }

        private void btnPalabras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("arriba , subir , abajo , bajar , izquierda , siniestra, derecha , negro , amarillo", "Lista de Palabras de muevelo con la voz", MessageBoxButtons.OKCancel);
        }

        private void btnAuto1_Click(object sender, EventArgs e)
        {
            Carrito2.Visible = true;

            if (Carrito2.Visible==true)
            {
                Carrito.Visible = false;
                Motocicleta.Visible = false;
            }
            

        }

        private void btnAuto2_Click(object sender, EventArgs e)
        {
            Carrito.Visible = true;

            if (Carrito.Visible == true)
            {
                Carrito2.Visible = false;
                Motocicleta.Visible = false;
            }
        }

        private void btnMoto_Click(object sender, EventArgs e)
        {
            Motocicleta.Visible = true;

            if(Motocicleta.Visible == true)
            {
                Carrito.Visible = false;
                Carrito2.Visible = false;
            }

        }



        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


        }

        private void Listo_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }
    }


}


