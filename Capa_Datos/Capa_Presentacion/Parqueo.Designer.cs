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
            this.label1 = new System.Windows.Forms.Label();
            this.btnParqueo = new System.Windows.Forms.Button();
            this.Carro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parqueo";
            // 
            // btnParqueo
            // 
            this.btnParqueo.Location = new System.Drawing.Point(428, 13);
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
            this.Carro.Location = new System.Drawing.Point(364, 298);
            this.Carro.Name = "Carro";
            this.Carro.Size = new System.Drawing.Size(126, 86);
            this.Carro.TabIndex = 2;
            this.Carro.TabStop = false;
            // 
            // Parqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 533);
            this.Controls.Add(this.Carro);
            this.Controls.Add(this.btnParqueo);
            this.Controls.Add(this.label1);
            this.Name = "Parqueo";
            this.Text = "Parqueo";
            this.Load += new System.EventHandler(this.Parqueo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParqueo;
        private System.Windows.Forms.PictureBox Carro;
    }
}