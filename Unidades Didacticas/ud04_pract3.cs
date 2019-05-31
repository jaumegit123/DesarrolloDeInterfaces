using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidades_Didacticas
{
    public partial class ud4_pract3 : Form
    {
        public ud4_pract3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
                comboBox1.Items.Add(textBox1.Text);
            else
                MessageBox.Show("La caja de texto no puede estar vacía.");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                if (textBox1.TextLength != 0) { 
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                }
                else
                    MessageBox.Show("La caja de texto no puede estar vacía.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No hay ningún item seleccionado.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No hay ningún item seleccionado.");
            }
        }
    }
}
