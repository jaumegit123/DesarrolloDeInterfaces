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
    public partial class ud4_pract2 : Form
    {
        public ud4_pract2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                MessageBox.Show("No se puede añadir un texto en blanco.");
            else
                listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay Items disponibles!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = listBox1.SelectedItem.ToString();
                textBox2.Focus();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay Items disponibles!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items[listBox1.SelectedIndex] = textBox2.Text;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay Items disponibles!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay Items seleccionados/disponibles!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("No hay Items disponibles!");
            else
                listBox1.Items.Clear();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay Items disponibles!");
            }
        }
        
    }
}
