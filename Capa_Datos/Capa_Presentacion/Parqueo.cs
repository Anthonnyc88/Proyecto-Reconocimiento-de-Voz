using System;
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

        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();
        public Parqueo()
        {
            InitializeComponent();
        }

        private void Parqueo_Load(object sender, EventArgs e)
        {
            Carrito.Visible = true;
            Carrito.Visible = true;
            
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

           
            Carrito.Visible = true;
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
                label2.Text = palabra.Text;

                if (palabra.Text.Equals("izquierda"))
                {
                    Carrito.Location = new Point(Carrito.Location.X - 20, Carrito.Location.Y);
                    Carrito2.Location = new Point(Carrito2.Location.X - 20, Carrito2.Location.Y);
                }
                else if (palabra.Text.Equals("derecha")) {
                    Carrito.Location = new Point(Carrito.Location.X + 20, Carrito.Location.Y);
                    Carrito2.Location = new Point(Carrito2.Location.X + 20, Carrito2.Location.Y);

                }
                else if (palabra.Text.Equals("arriba"))
                {
                    Carrito.Location = new Point(Carrito.Location.X , Carrito.Location.Y -20);
                    Carrito2.Location = new Point(Carrito2.Location.X, Carrito2.Location.Y - 20);

                }
                else if (palabra.Text.Equals("abajo"))
                {
                    Carrito.Location = new Point(Carrito.Location.X, Carrito.Location.Y + 20);
                    Carrito2.Location = new Point(Carrito2.Location.X, Carrito2.Location.Y + 20);

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
            this.Hide();
            Principal a = new Principal();
            a.Show();
           
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }

        private void btnPalabras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("arriba , abajo , izquierda , derecha , negro , amarillo", "Lista de Palabras de muevelo con la voz", MessageBoxButtons.OKCancel);
        }
    }


}


