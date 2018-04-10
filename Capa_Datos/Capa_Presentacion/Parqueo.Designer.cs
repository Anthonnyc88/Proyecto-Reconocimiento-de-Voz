namespace Capa_Presentacion
{
    partial class Parqueo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parqueo));
            this.btnParqueo = new System.Windows.Forms.Button();
            this.Carro = new System.Windows.Forms.PictureBox();
            this.palabra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.Barrita = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPalabras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParqueo
            // 
            this.btnParqueo.Location = new System.Drawing.Point(740, 4);
            this.btnParqueo.Name = "btnParqueo";
            this.btnParqueo.Size = new System.Drawing.Size(75, 23);
            this.btnParqueo.TabIndex = 1;
            this.btnParqueo.Text = "Parquear";
            this.btnParqueo.UseVisualStyleBackColor = true;
            this.btnParqueo.Click += new System.EventHandler(this.btnParqueo_Click);
            // 
            // Carro
            // 
            this.Carro.Image = ((System.Drawing.Image)(resources.GetObject("Carro.Image")));
            this.Carro.Location = new System.Drawing.Point(428, 190);
            this.Carro.Name = "Carro";
            this.Carro.Size = new System.Drawing.Size(131, 93);
            this.Carro.TabIndex = 2;
            this.Carro.TabStop = false;
            // 
            // palabra
            // 
            this.palabra.AutoSize = true;
            this.palabra.Location = new System.Drawing.Point(1, 9);
            this.palabra.Name = "palabra";
            this.palabra.Size = new System.Drawing.Size(43, 13);
            this.palabra.TabIndex = 3;
            this.palabra.Text = "Palabra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPrueba.Location = new System.Drawing.Point(4, 176);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(243, 134);
            this.btnPrueba.TabIndex = 5;
            this.btnPrueba.Text = "Parqueo 1";
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Barrita
            // 
            this.Barrita.BackColor = System.Drawing.Color.OrangeRed;
            this.Barrita.Location = new System.Drawing.Point(4, 510);
            this.Barrita.Name = "Barrita";
            this.Barrita.Size = new System.Drawing.Size(925, 23);
            this.Barrita.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(821, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPalabras
            // 
            this.btnPalabras.Location = new System.Drawing.Point(637, 4);
            this.btnPalabras.Name = "btnPalabras";
            this.btnPalabras.Size = new System.Drawing.Size(87, 23);
            this.btnPalabras.TabIndex = 8;
            this.btnPalabras.Text = "Lista Palabras";
            this.btnPalabras.UseVisualStyleBackColor = true;
            this.btnPalabras.Click += new System.EventHandler(this.btnPalabras_Click);
            // 
            // Parqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(930, 539);
            this.Controls.Add(this.btnPalabras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Barrita);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.palabra);
            this.Controls.Add(this.Carro);
            this.Controls.Add(this.btnParqueo);
            this.Name = "Parqueo";
            this.Text = "Parqueo";
            this.Load += new System.EventHandler(this.Parqueo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParqueo;
        private System.Windows.Forms.PictureBox Carro;
        private System.Windows.Forms.Label palabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.ProgressBar Barrita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPalabras;
    }
}