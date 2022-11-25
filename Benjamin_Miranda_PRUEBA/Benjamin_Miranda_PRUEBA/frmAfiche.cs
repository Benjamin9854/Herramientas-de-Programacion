using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Benjamin_Miranda_PRUEBA
{
    public partial class frmAfiche : Form
    {
        
            public frmAfiche()
            {
                InitializeComponent();
            }

            public void frmAfiche_Load(object sender, EventArgs e)
            {
                
            }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            string linea;
            try
            {
                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        lblPromociones.Text = null;

                        StreamReader sr = new StreamReader(file);
                        linea = sr.ReadLine();

                        while (linea != null)
                        {
                            lblPromociones.Text += linea + System.Environment.NewLine;
                            linea = sr.ReadLine();
                        }
                        sr.Close();
                    }
                }
                
            }
            catch (Exception ex) { MessageBox.Show("ERROR: " + ex.Message); }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //Leer archivos
                foreach (string file in openFileDialog1.FileNames)
                {
                    try
                    {
                        Image img = EscalarImagen(Image.FromFile(file), 300, 200);
                        pictBox.Height = img.Height;
                        pictBox.Width = img.Width;
                        pictBox.Image = img;
                    }
                    catch (SecurityException ex) { MessageBox.Show("Error de seguridad: " + ex.Message); }
                    catch (Exception ex) { MessageBox.Show("Error, no se puede mostrar la imagen"); }
                }
            }
        }

        public static Image EscalarImagen(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            using (var graphics = Graphics.FromImage(newImage)) graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void InitializeOpenFileDialog()
        {
            this.openFileDialog1.Filter = "Images (*.BMP; *.JPG; *.GIF |" + "All Files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Seleccione una o varias imagenes";
        }
    }
}
