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
    public partial class ud7_pract1 : Form {

        public ud7_pract1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                if (Int32.Parse(tbRangoMin.Text) < 0) {
                    tbRangoMin.Clear();
                    MessageBox.Show("El límite inferior no puede ser menor de 0.");
                }
            } catch (FormatException) {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            try {
                if (Int32.Parse(tbRangoMax.Text) > 10000) {
                    tbRangoMax.Clear();
                    MessageBox.Show("El límite superior no puede ser mayor de 10000.");
                } else if ((Int32.Parse(tbRangoMax.Text) - (Int32.Parse(tbRangoMin.Text))) > 100) {
                    tbRangoMax.Clear();
                    MessageBox.Show("La diferencia entre los dos límites no puede ser mayor de 100.");
                }
            } catch (FormatException) {

            }
        }

        private Boolean esPrimo(int numero) {
            int contador = 2;
            Boolean primo = true;
            while ((primo) && (contador != numero)) {
                if (numero % contador == 0)
                    primo = false;
                contador++;
            }
            return primo;
        }

        private void btnBucleFor_Click(object sender, EventArgs e) {
            listBox1.Items.Clear(); listBox2.Items.Clear();
            int InicioRango = Int32.Parse(tbRangoMin.Text);
            int FinRango = Int32.Parse(tbRangoMax.Text);
            for (int x = InicioRango; x <= FinRango; x++) {
                if (esPrimo(x)) {
                    if ((listBox1.Items.Count + listBox2.Items.Count) % 2 == 0)
                        listBox1.Items.Add(x);
                    else
                        listBox2.Items.Add(x);
                }
            }
            if ((listBox1.Items.Count + listBox2.Items.Count) < 10) {
                foreach (int item in listBox2.Items)
                    listBox1.Items.Add(item);
                listBox2.Items.Clear();
            }
            pictureBox1.Image = Properties.Resources.capturaBucleFor;
            pictureBox1.Size = Properties.Resources.capturaBucleFor.Size;
        }

        private void btnBucleWhile_Click(object sender, EventArgs e) {
            listBox1.Items.Clear(); listBox2.Items.Clear();
            int InicioRango = Int32.Parse(tbRangoMin.Text);
            int FinRango = Int32.Parse(tbRangoMax.Text);
            int x = InicioRango;
            while (x <= FinRango) {
                if (esPrimo(x)) {
                    if ((listBox1.Items.Count + listBox2.Items.Count) % 2 == 0)
                        listBox1.Items.Add(x);
                    else
                        listBox2.Items.Add(x);
                }
                x++;
            }
            if ((listBox1.Items.Count + listBox2.Items.Count) < 10) {
                foreach (int item in listBox2.Items)
                    listBox1.Items.Add(item);
                listBox2.Items.Clear();
            }
            pictureBox1.Image = Properties.Resources.capturaBucleWhile;
            pictureBox1.Size = Properties.Resources.capturaBucleWhile.Size;
        }

         private int factorial(int num) {
            if (num == 0) {
                return 1;
            }
            else
                return num * factorial(num - 1);
         }

        private void button4_Click(object sender, EventArgs e) {
            if (Int32.Parse(textBox3.Text) > 0 && Int32.Parse(textBox3.Text) < 16)
                label3.Text = factorial(Int32.Parse(textBox3.Text)).ToString();
            else
                MessageBox.Show("El número debe de estar entre 0 y 16", "Error");
        }
    }

}
