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
            this.CenterToScreen();
        }

        private void Parqueo_Load(object sender, EventArgs e)
        {
            Carro.Visible = false;

            Choices ListaPalabras = new Choices();
            ListaPalabras.Add(new string[] { "auto", "carro", "salir" });
            Grammar gramatica = new Grammar(new GrammarBuilder(ListaPalabras));

            try
            {

                escucha.SetInputToDefaultAudioDevice();
                //Capta las palabras
                escucha.LoadGrammar(new DictationGrammar());
                escucha.SpeechRecognized += Reconocimiento;
                escucha.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch(Exception)
            {
                throw;

            }

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

            label1.Visible = false;
            try
            {
                escucha.SetInputToDefaultAudioDevice();

                //Capta las palabras
                escucha.LoadGrammar(new DictationGrammar());
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Lector);
                escucha.RecognizeAsync(RecognizeMode.Multiple);



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

    }

}


