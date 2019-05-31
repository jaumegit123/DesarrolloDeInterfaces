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
    public partial class ud6_pract2 : Form {
        public ud6_pract2() {
            InitializeComponent();
        }

        private void btnByVal_Click(object sender, EventArgs e) {
            int sumando1 = Int32.Parse(tbSumando1.Text);
            int sumando2 = Int32.Parse(tbSumando2.Text);
            byVal(sumando1, sumando2);
            pictureBox1.Image = Properties.Resources.byVal;
        }

        private void btnByRef_Click(object sender, EventArgs e) {
            int sumando1 = Int32.Parse(tbSumando1.Text);
            int sumando2 = Int32.Parse(tbSumando2.Text);
            byRef(ref sumando1, ref sumando2);
            pictureBox1.Image = Properties.Resources.byRef;
        }

        public void byVal(int sum1, int sum2) {
            lblResultado.Text = (sum1 + sum2).ToString();
            tbSumando1.Text = (Int32.Parse(tbSumando1.Text) + 2).ToString();
        }

        public void byRef(ref int sum1, ref int sum2) {
            lblResultado.Text = (sum1 + sum2).ToString();
            tbSumando1.Text = (Int32.Parse(tbSumando1.Text) + 2).ToString();
        }
    }
}
