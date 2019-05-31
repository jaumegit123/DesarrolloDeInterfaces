using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidades_Didacticas {
    public partial class ud9_pract3_opcional : Form {

        // Un hilo para cada tarea
        private static Thread hilo1;
        private static Thread hilo2;
        private static Thread hilo3;
        private static Thread hilo4;

        // Un MRE y un array de MRE para sincronizar a todos los hilos
        private ManualResetEvent mre = new ManualResetEvent(false);
        private ManualResetEvent[] mreArray = new ManualResetEvent[1];

        private static Thread hilo5;

        // Un delegado para hacer llamadas seguras con los hilos
        private delegate void delegado();

        // Contadores para cada proceso
        private int cont1 = 0;
        private int cont2 = 0;
        private int cont3 = 0;
        private int cont4 = 0;

        private int anchura;

        public ud9_pract3_opcional() {
            InitializeComponent();
            anchura = PictureBox1.Width;
            mreArray[0] = mre;
            cmbTipo.SelectedIndex = 0;
        }

        private void btnControl_Click(object sender, EventArgs e) {
            hilo1 = new Thread(threadSafe);
            hilo2 = new Thread(threadSafe);
            hilo3 = new Thread(threadSafe);
            hilo4 = new Thread(threadSafe);
            hilo1.Name = "t1";
            hilo2.Name = "t2";
            hilo3.Name = "t3";
            hilo4.Name = "t4";
            hilo1.IsBackground = true;
            hilo2.IsBackground = true;
            hilo3.IsBackground = true;
            hilo4.IsBackground = true;
            switch (cmbTipo.SelectedIndex) {
                case 0:
                    hilo1.Start();
                    hilo2.Start();
                    hilo3.Start();
                    hilo4.Start();
                    break;
                case 1:
                    hilo1.Start();
                    hilo2.Start();
                    hilo3.Start();
                    hilo4.Start();
                    hilo4.Priority = ThreadPriority.Lowest;
                    break;
                case 2:
                    hilo3 = null;
                    hilo1.Start();
                    hilo2.Start();
                    hilo4.Start();
                    hilo5 = new Thread(empezar3);
                    hilo5.IsBackground = true;
                    hilo5.Start();
                    break;
                case 3:
                    hilo1 = null;
                    hilo2.Start();
                    hilo3.Start();
                    hilo4.Start();
                    hilo5 = new Thread(empezar1);
                    hilo5.IsBackground = true;
                    hilo5.Start();
                    break;
            }

        }

        private void empezar3() {
            while (true) {
                if(!hilo2.IsAlive && !hilo4.IsAlive) {
                    hilo3 = new Thread(threadSafe);
                    hilo3.Name = "t3";
                    hilo3.IsBackground = true;
                    hilo3.Start();
                    break;
                }
            }
        }

        private void empezar1() {
            while (true) {
                if (!hilo2.IsAlive) {
                    hilo1 = new Thread(threadSafe);
                    hilo1.Name = "t1";
                    hilo1.IsBackground = true;
                    hilo1.Start();
                    break;
                }
            }
        }

        private void threadSafe() {
            switch (Thread.CurrentThread.Name) {
                case "t1":
                    while (progressBar1.Value < progressBar1.Maximum) {
                        for (int i = 1; i <= 3; i++) {
                            MethodInvoker metodoConParametro = new MethodInvoker(delegate {
                                tarea1(i, false);
                            });
                            BeginInvoke(new delegado(metodoConParametro));
                            Thread.Sleep(500);
                        }
                        WaitHandle.WaitAll(mreArray, 0, true);
                    }
                    break;
                case "t2":
                    while (progressBar2.Value < progressBar2.Maximum) {
                        for (int i = 1; i <= 3; i++) {
                            MethodInvoker metodoConParametro = new MethodInvoker(delegate {
                                tarea2(i, false);
                            });
                            BeginInvoke(new delegado(metodoConParametro));
                            Thread.Sleep(500);
                        }
                        WaitHandle.WaitAll(mreArray, 0, true);
                    }
                    break;
                case "t3":
                    while (progressBar3.Value < progressBar3.Maximum) {
                        for (int i = 1; i <= 3; i++) {
                            MethodInvoker metodoConParametro = new MethodInvoker(delegate {
                                tarea3(i, true);
                            });
                            BeginInvoke(new delegado(metodoConParametro));
                            Thread.Sleep(500);
                        }
                        WaitHandle.WaitAll(mreArray, 0, true);
                    }
                    break;
                case "t4":
                    while (progressBar4.Value < progressBar4.Maximum) {
                        for (int i = 1; i <= 3; i++) {
                            MethodInvoker metodoConParametros = new MethodInvoker(delegate {
                                tarea4(i, true);
                            });
                            BeginInvoke(new delegado(metodoConParametros));
                            Thread.Sleep(500);
                        }
                        WaitHandle.WaitAll(mreArray, 0, true);
                    }
                    break;
            }
        }

        private void tarea1(int pos, Boolean segundoBloque) {
            visibilizar(pos, segundoBloque);
            progressBar1.PerformStep();
            cont1++;
            lblCont1.Text = cont1.ToString();
        }

        private void tarea2(int pos, Boolean segundoBloque) {
            redimensionar(pos, segundoBloque);
            progressBar2.PerformStep();
            cont2++;
            lblCont2.Text = cont2.ToString();
        }

        private void tarea3(int pos, Boolean segundoBloque) {
            redimensionar(pos, segundoBloque);
            progressBar3.PerformStep();
            cont3++;
            lblCont3.Text = cont3.ToString();
        }

        private void tarea4(int pos, Boolean segundoBloque) {
            visibilizar(pos, segundoBloque);
            progressBar4.PerformStep();
            cont4++;
            lblCont4.Text = cont4.ToString();
        }

        private void visibilizar(int pos, Boolean segundoBloque) {
            if (!segundoBloque) {
                switch (pos) {
                    case 1:
                        PictureBox1.Visible = true;
                        PictureBox2.Visible = false;
                        PictureBox3.Visible = false;
                        break;
                    case 2:
                        PictureBox1.Visible = false;
                        PictureBox2.Visible = true;
                        PictureBox3.Visible = false;
                        break;
                    case 3:
                        PictureBox1.Visible = false;
                        PictureBox2.Visible = false;
                        PictureBox3.Visible = true;
                        break;
                }
            } else {
                switch (pos) {
                    case 1:
                        pictureBox10.Visible = true;
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
                        break;
                    case 2:
                        pictureBox10.Visible = false;
                        pictureBox11.Visible = true;
                        pictureBox12.Visible = false;
                        break;
                    case 3:
                        pictureBox10.Visible = false;
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = true;
                        break;
                }
            }

            
        }

        private void redimensionar(int pos, Boolean segundoBloque) {
            if (!segundoBloque) {
                switch (pos) {
                    case 1:
                        PictureBox4.Width = anchura / 2;
                        PictureBox5.Width = anchura;
                        PictureBox6.Width = anchura;
                        break;
                    case 2:
                        PictureBox4.Width = anchura;
                        PictureBox5.Width = anchura / 2;
                        PictureBox6.Width = anchura;
                        break;
                    case 3:
                        PictureBox4.Width = anchura;
                        PictureBox5.Width = anchura;
                        PictureBox6.Width = anchura / 2;
                        break;
                }
            } else {
                switch (pos) {
                    case 1:
                        pictureBox7.Width = anchura / 2;
                        pictureBox8.Width = anchura;
                        pictureBox9.Width = anchura;
                        break;
                    case 2:
                        pictureBox7.Width = anchura;
                        pictureBox8.Width = anchura / 2;
                        pictureBox9.Width = anchura;
                        break;
                    case 3:
                        pictureBox7.Width = anchura;
                        pictureBox8.Width = anchura;
                        pictureBox9.Width = anchura / 2;
                        break;
                }
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if (hilo1 != null)
                hilo1.Abort();
            if (hilo2 != null)
                hilo2.Abort();
            if (hilo3 != null)
                hilo3.Abort();
            if (hilo4 != null)
                hilo4.Abort();
            if (hilo5 != null)
                hilo5.Abort();

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;

            cont1 = 0;
            cont2 = 0;
            cont3 = 0;
            cont4 = 0;

            lblCont1.Text = "0";
            lblCont2.Text = "0";
            lblCont3.Text = "0";
            lblCont4.Text = "0";
        }

        private void ud9_pract3_opcional_FormClosing(object sender, FormClosingEventArgs e) {
            if(hilo1 != null)
                hilo1.Abort();
            if (hilo2 != null)
                hilo2.Abort();
            if (hilo3 != null)
                hilo3.Abort();
            if (hilo4 != null)
                hilo4.Abort();
            if (hilo5 != null)
                hilo5.Abort();
        }
    }
}
