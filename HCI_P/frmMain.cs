using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_P {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnPretraziSliku_Click(object sender, EventArgs e) {
            lblFocus.Focus();
            openFileDialog.ShowDialog();

            int resizedImageWidth = 120;
            int resizedImageHeight = 120;

            try {
                Image image = Image.FromFile(openFileDialog.FileName);
                if (image.Width > resizedImageWidth || image.Height > resizedImageHeight) {
                    txtSlikaInput.Text = openFileDialog.FileName;
                    Bitmap resizedImage = ResizeImage(image, new Size(resizedImageWidth, resizedImageHeight));

                    pictureBox.Image = resizedImage;
                }
                else {
                    MessageBox.Show("Potrebno je da odaberete sliku dimenzija većih od" + " " + resizedImageWidth + "x" + resizedImageHeight + ".", "Upozorenje!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show(Owner, "Neispravan format za sliku!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSlikaInput.Clear();
                openFileDialog.FileName = "";
            }
            catch (FileNotFoundException) {
                txtSlikaInput.Clear();
                openFileDialog.FileName = "";
            }
            catch (ArgumentException) {
                txtSlikaInput.Clear();
                openFileDialog.FileName = "";
            }
        }
        public static Bitmap ResizeImage(Image imgToResize, Size size) {

            Bitmap b = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imgToResize, 0, 0, 120, 120);
            g.Dispose();
            return b;
        }

        private void btnMatrica_Click(object sender, EventArgs e) {
            if (pictureBox.Image == null || txtSlikaInput.Text == "") {
                MessageBox.Show("Potrebno je da odaberete sliku!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap slika = (Bitmap)pictureBox.Image;

            int hight = slika.Height;
            int width = slika.Width;

            Color[][] colorMatrix = new Color[width][];
            for (int i = 0; i < width; i++) {
                colorMatrix[i] = new Color[hight];
                for (int j = 0; j < hight; j++) {
                    colorMatrix[i][j] = slika.GetPixel(i, j);
                }
            }
            string IspisMatrica = string.Empty;
            for (int i = 0; i < slika.Height; i++) {
                IspisMatrica += "{";
                for (int j = 0; j < slika.Width; j++) {
                    IspisMatrica += "[";
                    IspisMatrica += colorMatrix[i][j].R + ",";
                    IspisMatrica += colorMatrix[i][j].G + ",";
                    IspisMatrica += colorMatrix[i][j].B + "], ";
                }
                IspisMatrica += "}";
                IspisMatrica += "\n";
            }
            LoadingForm frm = new LoadingForm();
            btnMatrica.Enabled = false;
            new frmMatrica(IspisMatrica).ShowDialog();
            btnMatrica.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e) {
            txtSlikaInput.Enabled = false;
        }

        private void btnIzlaz_Click_1(object sender, EventArgs e) {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }
    }
}
