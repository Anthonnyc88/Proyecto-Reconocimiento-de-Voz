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
            Carro.Visible = true;
            
        }

        public void Reconocimiento(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Equals("auto"))
            {
                Carro.Visible = true;
            }
            else if (e.Result.Text.Equals("carro"))
            {
                Carro.Visible = true;
            }
            else if (e.Result.Text.Equals("salir"))
            {
                Application.Exit();
            }


        }

        private void btnParqueo_Click(object sender, EventArgs e)
        {

           
            Carro.Visible = true;
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
                    Carro.Location = new Point(Carro.Location.X - 20, Carro.Location.Y);
                }
                else if (palabra.Text.Equals("derecha")) {
                    Carro.Location = new Point(Carro.Location.X + 20, Carro.Location.Y);

                }
                else if (palabra.Text.Equals("arriba"))
                {
                    Carro.Location = new Point(Carro.Location.X , Carro.Location.Y -20);

                }
                else if (palabra.Text.Equals("abajo"))
                {
                    Carro.Location = new Point(Carro.Location.X, Carro.Location.Y + 20);

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
            MessageBox.Show("arriba , abajo , izquierda , derecha", "Lista de Palabras de muevelo con la voz", MessageBoxButtons.OKCancel);
        }
    }


}


