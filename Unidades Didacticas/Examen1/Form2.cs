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
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private Boolean numerosOrdenados(String numeros) {
            char[] arrNumeros = numeros.ToCharArray();
            int numMajor = 0;

            for (int i = 0; i < arrNumeros.Length; i++) {
                numMajor = (int)Char.GetNumericValue(arrNumeros[i]);

                try {
                    if (numMajor < (int)Char.GetNumericValue(arrNumeros[i + 1])) {
                        return false;
                    }
                } catch (IndexOutOfRangeException) {

                }
            }
            return true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Return) {
                if (textBox1.TextLength <= 8 && textBox1.Text.All(c => char.IsDigit(c)) && numerosOrdenados(textBox1.Text) == true) {
                    MessageBox.Show("Correcto!");
                    textBox2.Enabled = true;
                } else {
                    MessageBox.Show("Incorrecto!");
                    textBox2.Enabled = false;
                }

            }
        }
    }
}
