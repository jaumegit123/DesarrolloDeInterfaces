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
    public partial class ud5_pract1 : Form
    {
        public ud5_pract1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0) {
                MessageBox.Show("Has de llenar los 3 campos!");
            } else {
                ListViewItem lista = new ListViewItem(textBox1.Text);
                lista.SubItems.Add(textBox2.Text);
                lista.SubItems.Add(textBox3.Text);
                listView1.Items.Add(lista);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                listView1.Items.RemoveAt(listView1.FocusedItem.Index);
            } catch (NullReferenceException) {
                MessageBox.Show("No hay Items seleccionados/disponibles!");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (listView1.Items.Count == 0)
                MessageBox.Show("No hay Items disponibles!");
            else
                listView1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (textBox1.TextLength > 8 && textBox1.Text.Any(c => char.IsDigit(c))) {
                lblAvisoNombre.Visible = true;
                lblAvisoNombre.Text = "El nombre no puede ser mayor de 8 carácteres\nEl nombre no puede tener números";
            } else if (textBox1.TextLength > 8) {
                lblAvisoNombre.Visible = true;
                lblAvisoNombre.Text = "El nombre no puede ser mayor de 8 carácteres";
            } else if (textBox1.Text.Any(c => char.IsDigit(c))) {
                lblAvisoNombre.Visible = true;
                lblAvisoNombre.Text = "El nombre no puede tener números";
            } else {
                lblAvisoNombre.Visible = false;
            }
            comprobar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            try {
                if (textBox2.TextLength > 10 && !textBox2.Text.Substring(0, 1).Equals("C") && !textBox2.Text.Any(c => char.IsDigit(c))) {
                    lblAvisoDir.Visible = true;
                    lblAvisoDir.Text = "La primera letra de la dirección debe de ser C\nLa dirección debe contener el número de vivienda\nLa dirección no puede ser mayor de 10 carácteres";
                } else if (!textBox2.Text.Substring(0, 1).Equals("C")) {
                        lblAvisoDir.Visible = true;
                        lblAvisoDir.Text = "La primera letra de la dirección debe de ser C";
                    } else if (!textBox2.Text.Any(c => char.IsDigit(c))) {
                        lblAvisoDir.Visible = true;
                        lblAvisoDir.Text = "La dirección debe contener el número de vivienda";
                    } else if (textBox2.TextLength > 10) {
                        lblAvisoDir.Visible = true;
                        lblAvisoDir.Text = "La dirección no puede ser mayor de 10 carácteres";
                    } else {
                        lblAvisoDir.Visible = false;
                    }
            } catch (ArgumentOutOfRangeException) {

            }
            comprobar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            if (textBox3.TextLength != 9 && !textBox3.Text.All(c => char.IsDigit(c))) {
                lblAvisoTlf.Visible = true;
                lblAvisoTlf.Text = "Solo números permitidos\nEl teléfono debe de tener 9 números";
            }
            else if (!textBox3.Text.All(c => char.IsDigit(c))) {
                lblAvisoTlf.Visible = true;
                lblAvisoTlf.Text = "Solo números permitidos";
            }
            else if (textBox3.TextLength != 9) {
                lblAvisoTlf.Visible = true;
                lblAvisoTlf.Text = "El teléfono debe de tener 9 números";
            } else {
                lblAvisoTlf.Visible = false;
            }
            comprobar();
        }

        private void comprobar() {
            if (lblAvisoNombre.Visible == false && lblAvisoDir.Visible == false && lblAvisoTlf.Visible == false) {
                button1.Enabled = true;
            } else {
                button1.Enabled = false;
            }
        }

    }
}
