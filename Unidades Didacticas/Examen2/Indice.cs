using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2 {
    public partial class Indice : Form {

        public Indice() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new FormAct1().Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            //new FormAct2().Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            new FormAct3().Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            new FormAct4().Show();
            new FormAct4_2().Show();
        }
    }
}
