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
    public partial class ud9_pract2 : Form {

        //********* ATRIBUTOS **********//

        // Timer 1 normal
        private int decT1 = 0;
        private string horas = null;
        private string minutos = null;
        private string segundos = null;
        private string decimales = null;

        // Timer 2 con TimeSpan
        private int decT2 = 0;
        private TimeSpan ts;

        // Timer a partir de un Thread (hilo)
        private Thread nuestroThread;
        private ThreadStart threadStart;
        public delegate void MiDelegado();
        private MiDelegado deleg1;
        private int contador = 0;
        private bool comprobar = false;
        private string horasT3;
        private string minutosT3;
        private string segundosT3;

        public ud9_pract2() {
            InitializeComponent();
            threadStart = new ThreadStart(ActualizacionesBackground);

            // Declaración del delegado con la llamada al procedimiento FuncionGenerar
            deleg1 = new MiDelegado(FuncionGenerar);
        }

        //********* MÉTODOS **********//

        // Timer 1 normal
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
            decT1 = 0;
            lblCrono1.Text = "00:00:00:000";
            btnControlTimer1.Text = "Iniciar";
        }

        private void timer1_Tick(object sender, EventArgs e) {
            decT1 += 1;
            horas = (Math.Floor(decT1 / 36000.0) % 24).ToString("00");
            minutos = (Math.Floor(decT1 / 600.0) % 60).ToString("00");
            segundos = (Math.Floor(decT1 / 10.0) % 60).ToString("00");
            decimales = Math.Floor((double)(decT1 % 10)).ToString("0") + "00";
            lblCrono1.Text = horas + ":" + minutos + ":" + segundos + ":" + decimales;
        }

        // Timer 2 con TimeSpan
        private void btnControlTimer2TS_Click(object sender, EventArgs e) {
            if (timer2.Enabled == false) {
                timer2.Start();
                btnControlTimer2TS.Text = "Detener";
            } else if (timer2.Enabled == true) {
                timer2.Stop();
                btnControlTimer2TS.Text = "Continuar";
            }
        }

        private void btnResetTimer2TS_Click(object sender, EventArgs e) {
            timer2.Stop();
            decT2 = 0;
            lblCrono2.Text = "00:00:00:000";
            btnControlTimer2TS.Text = "Iniciar";
        }

        private void timer2_Tick(object sender, EventArgs e) {
            decT2 += 1;
            ts = TimeSpan.FromMilliseconds(decT2 * 100);
            if (ts.ToString().Length >= 12) {
                lblCrono2.Text = (ts.ToString().Substring(0, 12));
            } else
                lblCrono2.Text = ts.ToString() + ".000";
        }

        // Timer a partir de un Thread
        private void btnControlTimerThread_Click(object sender, EventArgs e) {
            try {
                if (comprobar == false) {
                    comprobar = true;
                    btnControlTimerThread.Text = "Detener";
                    lblSubproceso.Text = "En ejecución";
                    // Llamada a hilo -> ActualizacionesBackground
                    nuestroThread = new Thread(threadStart);
                    nuestroThread.IsBackground = true;
                    nuestroThread.Name = "nuestroThread";
                    nuestroThread.Start();
                } else {
                    comprobar = false;
                    btnControlTimerThread.Text = "Iniciar";
                    lblSubproceso.Text = "Detenido";
                }
            } catch (Exception ex) {
                lblSubproceso.Text = "Cancelado";
            }
        }

        private void btnResetTimerThread_Click(object sender, EventArgs e) {
            comprobar = false;
            contador = 0;
            lblCrono3.Text = "00:00:00";
            lblSubproceso.Text = "Terminado/Sin iniciar";
            btnControlTimerThread.Text = "Iniciar";
        }

        public void ActualizacionesBackground() {
            while (true) {
                if (comprobar == false) {
                    break;
                } else {
                    // Llamada al delegado -> FuncionGenerar
                    BeginInvoke(deleg1);
                    Thread.Sleep(1000);
                }
            }
        }

        public void FuncionGenerar() {
            try {
                // Al hacer uso del método Thread.Sleep() a 1000 milisegundos,
                // solo usaremos horas, minutos y segundos.
                contador += 1;
                horasT3 = (Math.Floor(contador / 3600.0) % 24).ToString("00");
                minutosT3 = (Math.Floor(contador / 60.0) % 60).ToString("00");
                segundosT3 = Convert.ToInt32(Math.Floor((double)(contador % 60))).ToString("00");
                lblCrono3.Text = horasT3 + ":" + minutosT3 + ":" + segundosT3;
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ud9_pract2_FormClosing(object sender, FormClosingEventArgs e) {
            if(nuestroThread != null)
                nuestroThread.Abort();
        }
    }
}
