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
            this.palabra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.Barrita = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPalabras = new System.Windows.Forms.Button();
            this.Carrito2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Carrito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParqueo
            // 
            this.btnParqueo.Image = ((System.Drawing.Image)(resources.GetObject("btnParqueo.Image")));
            this.btnParqueo.Location = new System.Drawing.Point(994, 5);
            this.btnParqueo.Margin = new System.Windows.Forms.Padding(4);
            this.btnParqueo.Name = "btnParqueo";
            this.btnParqueo.Size = new System.Drawing.Size(70, 72);
            this.btnParqueo.TabIndex = 1;
            this.btnParqueo.UseVisualStyleBackColor = true;
            this.btnParqueo.Click += new System.EventHandler(this.btnParqueo_Click);
            // 
            // palabra
            // 
            this.palabra.AutoSize = true;
            this.palabra.Location = new System.Drawing.Point(2, 10);
            this.palabra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.palabra.Name = "palabra";
            this.palabra.Size = new System.Drawing.Size(53, 15);
            this.palabra.TabIndex = 3;
            this.palabra.Text = "Palabra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 4;
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPrueba.ForeColor = System.Drawing.Color.Gold;
            this.btnPrueba.Location = new System.Drawing.Point(5, 263);
            this.btnPrueba.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(324, 130);
            this.btnPrueba.TabIndex = 5;
            this.btnPrueba.Text = "Parqueo 2";
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Barrita
            // 
            this.Barrita.BackColor = System.Drawing.Color.OrangeRed;
            this.Barrita.Location = new System.Drawing.Point(5, 549);
            this.Barrita.Margin = new System.Windows.Forms.Padding(4);
            this.Barrita.Name = "Barrita";
            this.Barrita.Size = new System.Drawing.Size(1201, 26);
            this.Barrita.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1148, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 72);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPalabras
            // 
            this.btnPalabras.Image = ((System.Drawing.Image)(resources.GetObject("btnPalabras.Image")));
            this.btnPalabras.Location = new System.Drawing.Point(1072, 5);
            this.btnPalabras.Margin = new System.Windows.Forms.Padding(4);
            this.btnPalabras.Name = "btnPalabras";
            this.btnPalabras.Size = new System.Drawing.Size(68, 72);
            this.btnPalabras.TabIndex = 8;
            this.btnPalabras.UseVisualStyleBackColor = true;
            this.btnPalabras.Click += new System.EventHandler(this.btnPalabras_Click);
            // 
            // Carrito2
            // 
            this.Carrito2.ForeColor = System.Drawing.Color.Black;
            this.Carrito2.Image = ((System.Drawing.Image)(resources.GetObject("Carrito2.Image")));
            this.Carrito2.Location = new System.Drawing.Point(543, 401);
            this.Carrito2.Margin = new System.Windows.Forms.Padding(4);
            this.Carrito2.Name = "Carrito2";
            this.Carrito2.Size = new System.Drawing.Size(168, 70);
            this.Carrito2.TabIndex = 10;
            this.Carrito2.Text = "Carro 2";
            this.Carrito2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(5, 401);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 128);
            this.button2.TabIndex = 11;
            this.button2.Text = "Parqueo 1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(5, 123);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 132);
            this.button3.TabIndex = 12;
            this.button3.Text = "Parqueo 3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.ForeColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(882, 401);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(324, 128);
            this.button4.TabIndex = 13;
            this.button4.Text = "Parqueo 4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.ForeColor = System.Drawing.Color.Gold;
            this.button5.Location = new System.Drawing.Point(882, 263);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(324, 130);
            this.button5.TabIndex = 14;
            this.button5.Text = "Parqueo 5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.ForeColor = System.Drawing.Color.Gold;
            this.button6.Location = new System.Drawing.Point(882, 123);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(324, 132);
            this.button6.TabIndex = 15;
            this.button6.Text = "Parqueo 6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Carrito
            // 
            this.Carrito.Image = global::Capa_Presentacion.Properties.Resources.if_TowTruckYellow_22997;
            this.Carrito.Location = new System.Drawing.Point(543, 263);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(168, 89);
            this.Carrito.TabIndex = 16;
            this.Carrito.Text = "Carro1";
            this.Carrito.UseVisualStyleBackColor = true;
            // 
            // Parqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1235, 586);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Carrito2);
            this.Controls.Add(this.btnPalabras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Barrita);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.palabra);
            this.Controls.Add(this.btnParqueo);
            this.Font = new System.Drawing.Font("Century", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Parqueo";
            this.Text = "Parqueo";
            this.Load += new System.EventHandler(this.Parqueo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParqueo;
        private System.Windows.Forms.Label palabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.ProgressBar Barrita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPalabras;
        private System.Windows.Forms.Button Carrito2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Carrito;
    }
}