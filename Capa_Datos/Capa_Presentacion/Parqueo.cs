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

                if (palabra.Text.Equals("Izquierda"))
                {
                    Carro.Location = new Point(Carro.Location.X - 20, Carro.Location.Y);
                }
                else if (palabra.Text.Equals("Derecha")) {
                    Carro.Location = new Point(Carro.Location.X + 20, Carro.Location.Y);

                }
                else if (palabra.Text.Equals("Arriba"))
                {
                    Carro.Location = new Point(Carro.Location.X , Carro.Location.Y -20);

                }
                else if (palabra.Text.Equals("Abajo"))
                {
                    Carro.Location = new Point(Carro.Location.X, Carro.Location.Y + 20);

                }

            }
        }

    }

}


