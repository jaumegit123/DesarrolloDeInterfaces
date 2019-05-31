using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidades_Didacticas {
    public partial class ud9_pract1 : Form {

        private int dec = 0;
        private string horas = null;
        private string minutos = null;
        private string segundos = null;
        private string decimales = null;
        private TimeSpan ts;
        private int anchura;
        private int cont = 0;
        private Random random = new Random();

        public ud9_pract1() {
            InitializeComponent();
        }

        private void ud9_pract1_Load(object sender, EventArgs e) { // se ejecuta al cargar el Form
            //Permitimos que se puedan manipular todas las imágenes
            PictureBox1.AllowDrop = true;
            PictureBox2.AllowDrop = true;
            PictureBox3.AllowDrop = true;
            PictureBox4.AllowDrop = true;
            PictureBox5.AllowDrop = true;
            PictureBox6.AllowDrop = true;
            PictureBox7.AllowDrop = true;
            PictureBox8.AllowDrop = true;

            // Asignamos los valores a los timers
            timer1.Interval = 100;
            timer2.Interval = 500;

            anchura = PictureBox1.Width;
            cmbTipo.SelectedIndex = 0;
        }

        private void btnControlTimer1_Click(object sender, EventArgs e) {
            if (timer1.Enabled == false) {
                timer1.Start();
                btnControlTimer1.Text = "Detener";
            } else if (timer1.Enabled == true) {
                timer1.Stop();
                btnControlTimer1.Text = "Continuar";
            }
        }

        private void btnResetTimer1_Click(object sender, EventArgs e) {
            timer1.Stop();
            dec = 0;
            lblCrono1.Text = "00:00:00:000";
            lblCrono2.Text = "00:00:00.000";
            btnControlTimer1.Text = "Iniciar";
        }

        private void timer1_Tick(object sender, EventArgs e) {
            dec += 1;

            //Temporizador normal
            horas = (Math.Floor(dec / 36000.0) % 24).ToString("00");
            minutos = (Math.Floor(dec / 600.0) % 60).ToString("00");
            segundos = (Math.Floor(dec / 10.0) % 60).ToString("00");
            decimales = Convert.ToInt32(Math.Floor((double)(dec % 10))).ToString("0") + "00";
            lblCrono1.Text = horas + ":" + minutos + ":" + segundos + ":" + decimales;

            //Temporizador con TimeSpan
            ts = TimeSpan.FromMilliseconds(dec * 100);
            if (ts.ToString().Length >= 12) {
                lblCrono2.Text = (ts.ToString().Substring(0, 12));
            } 
            else
                lblCrono2.Text = ts.ToString() + ".000";
        }

        private void btnControlTimer2_Click(object sender, EventArgs e) {
            if (timer2.Enabled == false) {
                timer2.Start();
                btnControlTimer2.Text = "Detener";
            } else if (timer2.Enabled == true) {
                timer2.Stop();
                btnControlTimer2.Text = "Iniciar";
            }
        }

        private void NudRefresh_ValueChanged(object sender, EventArgs e) {
            timer2.Interval = Convert.ToInt32(NudRefresh.Value);
        }

        private void timer2_Tick(object sender, EventArgs e) {
            cont += 1;
            switch (cmbTipo.SelectedItem.ToString()) {
                case "Intermitente":
                    visibilizar(cont);
                    break;
                case "Redimensionado":
                    redimensionar(cont);
                    break;
                case "Aleatorio & Redimensionado":
                    redimensionar(getRandom(1, 9));
                    break;
                case "Aleatorio & Intermitente":
                    visibilizar(getRandom(1, 9));
                    break;
            }
            if (cont == 8)
                cont = 0;
        }

        public int getRandom(int min, int max) {
            return random.Next(min, max);
        }

        private void visibilizar(int pos) {
            switch (pos) {
                case 1:
                    PictureBox1.Visible = true;
                    PictureBox2.Visible = false;
                    PictureBox3.Visible = false;
                    PictureBox4.Visible = false;
                    PictureBox5.Visible = false;
                    PictureBox6.Visible = false;
                    PictureBox7.Visible = false;
                    PictureBox8.Visible = false;
                    break;
                case 2:
                    PictureBox1.Visible = false;
                    PictureBox2.Visible = true;
                    PictureBox3.Visible = false;
                    PictureBox4.Visible = false;
                    PictureBox5.Visible = false;
                    PictureBox6.Visible = false;
                    PictureBox7.Visible = false;
                    PictureBox8.Visible = false;
                    break;
                case 3:
                    PictureBox1.Visible = false;
                    PictureBox2.Visible = false;
                    PictureBox3.Visible = true;
                    PictureBox4.Visible = false;
                    PictureBox5.Visible = false;
                    PictureBox6.Visible = false;
                    PictureBox7.Visible = false;
                    PictureBox8.Visible = false;
                    break;
                case 4:
                    PictureBox1.Visible = false;
                    PictureBox2.Visible = false;
                    PictureBox3.Visible = false;
                    PictureBox4.Visible = true;
                    PictureBox5.Visible = false;
                    PictureBox6.Visible = false;
                    PictureBox7.Visible = false;
                    PictureBox8.Visible = false;
                    break;
                case 5:
                    PictureBox1.Visible = false;
                    PictureBox2.Visible = false;
                    PictureBox3.Visible = false;
                    PictureBox4.Visible = false;
                    PictureBox5.Visible = true;
                    PictureBox6.Visible = false;
                    PictureBox7.Visible = false;
                    PictureBox8.Visible = false;
                    break;
                case 6:
                    PictureBox1.Visible = false;
                    PictureBox2.Visible = false;
                    PictureBox3.Visible = false;
                    PictureBox4.Visible = false;
                    PictureBox5.Visible = false;
                    PictureBox6.Visible = true;
                    PictureBox7.Visible = false;
                    PictureBox8.Visible = false;
                    break;
                case 7:
                    PictureBox1.Visible = false;
                    PictureBox2.Visible = false;
                    PictureBox3.Visible = false;
                    PictureBox4.Visible = false;
                    PictureBox5.Visible = false;
                    PictureBox6.Visible = false;
                    PictureBox7.Visible = true;
                    PictureBox8.Visible = false;
                    break;
                case 8:
                    PictureBox1.Visible = false;
                    PictureBox2.Visible = false;
                    PictureBox3.Visible = false;
                    PictureBox4.Visible = false;
                    PictureBox5.Visible = false;
                    PictureBox6.Visible = false;
                    PictureBox7.Visible = false;
                    PictureBox8.Visible = true;
                    break;
            }
        }

        private void redimensionar(int pos) {
            switch (pos) {
                case 1:
                    PictureBox1.Visible = true;
                    PictureBox1.Width = anchura / 2;
                    PictureBox2.Width = anchura;
                    PictureBox3.Width = anchura;
                    PictureBox4.Width = anchura;
                    PictureBox5.Width = anchura;
                    PictureBox6.Width = anchura;
                    PictureBox7.Width = anchura;
                    PictureBox8.Width = anchura;
                    break;
                case 2:
                    PictureBox1.Width = anchura ;
                    PictureBox2.Visible = true;
                    PictureBox2.Width = anchura / 2;
                    PictureBox3.Width = anchura;
                    PictureBox4.Width = anchura;
                    PictureBox5.Width = anchura;
                    PictureBox6.Width = anchura;
                    PictureBox7.Width = anchura;
                    PictureBox8.Width = anchura;
                    break;
                case 3:
                    PictureBox1.Width = anchura;
                    PictureBox2.Width = anchura;
                    PictureBox3.Visible = true;
                    PictureBox3.Width = anchura / 2;
                    PictureBox4.Width = anchura;
                    PictureBox5.Width = anchura;
                    PictureBox6.Width = anchura;
                    PictureBox7.Width = anchura;
                    PictureBox8.Width = anchura;
                    break;
                case 4:
                    PictureBox1.Width = anchura;
                    PictureBox2.Width = anchura;
                    PictureBox3.Width = anchura;
                    PictureBox4.Visible = true;
                    PictureBox4.Width = anchura / 2;
                    PictureBox5.Width = anchura;
                    PictureBox6.Width = anchura;
                    PictureBox7.Width = anchura;
                    PictureBox8.Width = anchura;
                    break;
                case 5:
                    PictureBox1.Width = anchura;
                    PictureBox2.Width = anchura;
                    PictureBox3.Width = anchura;
                    PictureBox4.Width = anchura;
                    PictureBox5.Visible = true;
                    PictureBox5.Width = anchura / 2;
                    PictureBox6.Width = anchura;
                    PictureBox7.Width = anchura;
                    PictureBox8.Width = anchura;
                    break;
                case 6:
                    PictureBox1.Width = anchura;
                    PictureBox2.Width = anchura;
                    PictureBox3.Width = anchura;
                    PictureBox4.Width = anchura;
                    PictureBox5.Width = anchura;
                    PictureBox6.Visible = true;
                    PictureBox6.Width = anchura / 2;
                    PictureBox7.Width = anchura;
                    PictureBox8.Width = anchura;
                    break;
                case 7:
                    PictureBox1.Width = anchura;
                    PictureBox2.Width = anchura;
                    PictureBox3.Width = anchura;
                    PictureBox4.Width = anchura;
                    PictureBox5.Width = anchura;
                    PictureBox6.Width = anchura;
                    PictureBox7.Visible = true;
                    PictureBox7.Width = anchura / 2;
                    PictureBox8.Width = anchura;
                    break;
                case 8:
                    PictureBox1.Width = anchura;
                    PictureBox2.Width = anchura;
                    PictureBox3.Width = anchura;
                    PictureBox4.Width = anchura;
                    PictureBox5.Width = anchura;
                    PictureBox6.Width = anchura;
                    PictureBox7.Width = anchura;
                    PictureBox8.Visible = true;
                    PictureBox8.Width = anchura / 2;
                    break;
            }
        }

        private void btnRestablecerImgs_Click(object sender, EventArgs e) {
            PictureBox1.Image = Properties.Resources.Pikachu_HGSS;
            PictureBox2.Image = Properties.Resources.blastoise;
            PictureBox3.Image = Properties.Resources.charizard;
            PictureBox4.Image = Properties.Resources.venusaur;
            PictureBox5.Image = Properties.Resources.Mewtwo_HGSS;
            PictureBox6.Image = Properties.Resources.lugia;
            PictureBox7.Image = Properties.Resources.arcanine;
            PictureBox8.Image = Properties.Resources.rayquaza;
            PictureBox1.Width = anchura;
            PictureBox2.Width = anchura;
            PictureBox3.Width = anchura;
            PictureBox4.Width = anchura;
            PictureBox5.Width = anchura;
            PictureBox6.Width = anchura;
            PictureBox7.Width = anchura;
            PictureBox8.Width = anchura;
            PictureBox1.Visible = true;
            PictureBox2.Visible = true;
            PictureBox3.Visible = true;
            PictureBox4.Visible = true;
            PictureBox5.Visible = true;
            PictureBox6.Visible = true;
            PictureBox7.Visible = true;
            PictureBox8.Visible = true;
        }

        // Métodos PictureBox_MouseDown (Con MouseMove no era necesario hacer click para arrastrar la imagen)
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox1.Image, DragDropEffects.Copy);
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox2.Image, DragDropEffects.Copy);
        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox3.Image, DragDropEffects.Copy);
        }

        private void PictureBox4_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox4.Image, DragDropEffects.Copy);
        }

        private void PictureBox5_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox5.Image, DragDropEffects.Copy);
        }

        private void PictureBox6_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox6.Image, DragDropEffects.Copy);
        }

        private void PictureBox7_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox7.Image, DragDropEffects.Copy);
        }

        private void PictureBox8_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(PictureBox8.Image, DragDropEffects.Copy);
        }

        // Métodos PictureBox_DragEnter
        private void PictureBox1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox2_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } 
        }

        private void PictureBox3_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox4_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox5_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox6_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox7_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox8_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Métodos PictureBox_DragDrop
        private void PictureBox1_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox1.Image = (Image) e.Data.GetData(DataFormats.Bitmap);
            }
        }

        private void PictureBox2_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        private void PictureBox3_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        private void PictureBox4_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        private void PictureBox5_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox5.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        private void PictureBox6_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox6.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        private void PictureBox7_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox7.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        private void PictureBox8_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                PictureBox8.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        // Liberamos los recursos de los timers al cerrar el Form
        private void ud9_pract1_FormClosing(object sender, FormClosingEventArgs e) {
            timer1.Dispose();
            timer2.Dispose();
        }
    }
}
