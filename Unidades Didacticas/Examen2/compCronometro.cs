using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Examen2 {
    public partial class compCronometro : UserControl {

        private TimeSpan ts;
        int dec = 0;

        public compCronometro() {
            InitializeComponent();
            timer1.Start();
        }

        private Boolean _reset;
        public Boolean Reset {
            get { return _reset; }
            set { _reset = value;
                dec = 0;
            }
        }

        public int _periodo;
        public int Periodo {
            get { return _periodo; }
            set { _periodo = value; }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            dec += 1;
            ts = TimeSpan.FromMilliseconds(dec * 1000);
                label1.Text = ts.ToString();
        }
    }
}
