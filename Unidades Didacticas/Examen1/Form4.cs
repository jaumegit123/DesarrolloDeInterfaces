using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidades_Didacticas.Examen1 {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int valor = Int32.Parse(textBox1.Text);
            int valor2 = Int32.Parse(textBox2.Text) * 2;
            int valor4 = Int32.Parse(textBox4.Text) * 4;
            int valor8 = Int32.Parse(textBox8.Text) * 8;
            int valor16 = Int32.Parse(textBox16.Text) * 16;
            int valor32 = Int32.Parse(textBox32.Text) * 32;
            int valor64 = Int32.Parse(textBox64.Text) * 64;
            int valor128 = Int32.Parse(textBox128.Text) * 128;

            int valorDecimal = valor + valor2 + valor4 + valor8 + valor16 + valor32 + valor64 + valor128;

            labelDec.Text = valorDecimal.ToString();

            labelHex.Text = valorDecimal.ToString("X");
        }
    }
}
