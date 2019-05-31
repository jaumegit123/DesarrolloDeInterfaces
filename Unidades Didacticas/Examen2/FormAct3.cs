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

namespace Examen2 {
    public partial class FormAct3 : Form {

        private static Thread hilo;
        private delegate void delegado();

        public FormAct3() {
            InitializeComponent();

            hilo = new Thread(evento);
            hilo.Start();
        }

        private void evento() {
            while (true) {
                Thread.Sleep(compCronometro1._periodo * 1000);
                BeginInvoke(new delegado(cambiarColor));
            }
        }

        private void cambiarColor() {
            compCronometro1.label1.ForeColor = Color.Aqua;
        }

    }
}
