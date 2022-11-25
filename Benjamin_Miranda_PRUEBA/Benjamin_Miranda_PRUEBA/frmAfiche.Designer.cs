namespace Benjamin_Miranda_PRUEBA
{
    partial class frmAfiche
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromociones = new System.Windows.Forms.Label();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barberia Nocturna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(187, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cortes de pelo y tratamientos de barba al mejor precio";
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromociones.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPromociones.Location = new System.Drawing.Point(241, 405);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.Size = new System.Drawing.Size(106, 13);
            this.lblPromociones.TabIndex = 3;
            this.lblPromociones.Text = "PROMOCIONES";
            this.lblPromociones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictBox
            // 
            this.pictBox.Location = new System.Drawing.Point(303, 114);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(413, 266);
            this.pictBox.TabIndex = 4;
            this.pictBox.TabStop = false;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(12, 12);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(130, 38);
            this.btnDatos.TabIndex = 5;
            this.btnDatos.Text = "Cargar datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(658, 12);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(130, 38);
            this.btnImagen.TabIndex = 6;
            this.btnImagen.Text = "Cargar imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAfiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.lblPromociones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAfiche";
            this.Text = "frmAfiche";
            this.Load += new System.EventHandler(this.frmAfiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPromociones;
        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}