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
    public partial class ud6_pract1 : Form
    {

        protected static Contacto[] arrContactosBorrados = new Contacto[0];

        public ud6_pract1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        protected void comprobar()
        {
            if (lblAvisoNombre.Visible == false && lblAvisoDir.Visible == false && lblAvisoTlf.Visible == false)
            {
                btnAnyadir.Enabled = true;
            }
            else
            {
                btnAnyadir.Enabled = false;
            }
        }

        public virtual void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 8 && textBox1.Text.Any(c => char.IsDigit(c)))
            {
                lblAvisoNombre.Visible = true;
                lblAvisoNombre.Text = "El nombre no puede ser mayor de 8 carácteres\nEl nombre no puede tener números";
            }
            else if (textBox1.TextLength > 8)
            {
                lblAvisoNombre.Visible = true;
                lblAvisoNombre.Text = "El nombre no puede ser mayor de 8 carácteres";
            }
            else if (textBox1.Text.Any(c => char.IsDigit(c)))
            {
                lblAvisoNombre.Visible = true;
                lblAvisoNombre.Text = "El nombre no puede tener números";
            }
            else
            {
                lblAvisoNombre.Visible = false;
            }
            comprobar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.TextLength > 10 && !textBox2.Text.Substring(0, 1).Equals("C") && !textBox2.Text.Any(c => char.IsDigit(c)))
                {
                    lblAvisoDir.Visible = true;
                    lblAvisoDir.Text = "La primera letra de la dirección debe de ser C\nLa dirección debe contener el número de vivienda\nLa dirección no puede ser mayor de 10 carácteres";
                }
                else if (!textBox2.Text.Substring(0, 1).Equals("C"))
                {
                    lblAvisoDir.Visible = true;
                    lblAvisoDir.Text = "La primera letra de la dirección debe de ser C";
                }
                else if (!textBox2.Text.Any(c => char.IsDigit(c)))
                {
                    lblAvisoDir.Visible = true;
                    lblAvisoDir.Text = "La dirección debe contener el número de vivienda";
                }
                else if (textBox2.TextLength > 10)
                {
                    lblAvisoDir.Visible = true;
                    lblAvisoDir.Text = "La dirección no puede ser mayor de 10 carácteres";
                }
                else
                {
                    lblAvisoDir.Visible = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            comprobar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 9 && !textBox3.Text.All(c => char.IsDigit(c)))
            {
                lblAvisoTlf.Visible = true;
                lblAvisoTlf.Text = "Solo números permitidos\nEl teléfono debe de tener 9 números";
            }
            else if (!textBox3.Text.All(c => char.IsDigit(c)))
            {
                lblAvisoTlf.Visible = true;
                lblAvisoTlf.Text = "Solo números permitidos";
            }
            else if (textBox3.TextLength != 9)
            {
                lblAvisoTlf.Visible = true;
                lblAvisoTlf.Text = "El teléfono debe de tener 9 números";
            }
            else
            {
                lblAvisoTlf.Visible = false;
            }
            comprobar();
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Has de llenar los 3 campos!");
            }
            else
            {
                ListViewItem lista = new ListViewItem(textBox1.Text);
                lista.SubItems.Add(textBox2.Text);
                lista.SubItems.Add(textBox3.Text);
                listView1.Items.Add(lista);
            }
        }

        private void btnBorrarSelected_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Resize(ref arrContactosBorrados, arrContactosBorrados.Length + 1);
                arrContactosBorrados[arrContactosBorrados.Length - 1] = new Contacto(listView1.FocusedItem.SubItems[0].Text,
                    listView1.FocusedItem.SubItems[1].Text, listView1.FocusedItem.SubItems[2].Text);
                listView1.Items.RemoveAt(listView1.FocusedItem.Index);
                contarContactosBorrados();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay Items seleccionados/disponibles!");
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
                MessageBox.Show("No hay Items disponibles!");
            else
            {
                Array.Resize(ref arrContactosBorrados, arrContactosBorrados.Length + listView1.Items.Count);
                for (int i = 0; i < arrContactosBorrados.Length; i++)
                {
                    if (arrContactosBorrados[i] == null)
                    {
                        arrContactosBorrados[i] = new Contacto(listView1.Items[i].SubItems[0].Text,
                            listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text);
                    }
                }
                listView1.Items.Clear();
                contarContactosBorrados();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int pos = -1;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Todos los campos":
                    for (int i = 0; i < arrContactosBorrados.Length; i++)
                    {
                        if (arrContactosBorrados[i] != null)
                        {
                            if (arrContactosBorrados[i].getNombre().Equals(textBox4.Text))
                            {
                                pos = i;
                                break;
                            }
                            else if (arrContactosBorrados[i].getDireccion().Equals(textBox4.Text))
                            {
                                pos = i;
                                break;
                            }
                            else if (arrContactosBorrados[i].getTelefono().Equals(textBox4.Text))
                            {
                                pos = i;
                                break;
                            }
                        }
                    }
                    mostrarMsg(pos);
                    break;
                case "Nombre":
                    for (int i = 0; i < arrContactosBorrados.Length; i++)
                    {
                        if (arrContactosBorrados[i] != null)
                        {
                            if (arrContactosBorrados[i].getNombre().Equals(textBox4.Text))
                            {
                                pos = i;
                                break;
                            }
                        }
                    }
                    mostrarMsg(pos);
                    break;
                case "Dirección":
                    for (int i = 0; i < arrContactosBorrados.Length; i++)
                    {
                        if (arrContactosBorrados[i] != null)
                        {
                            if (arrContactosBorrados[i].getDireccion().Equals(textBox4.Text))
                            {
                                pos = i;
                                break;
                            }
                        }
                    }
                    mostrarMsg(pos);
                    break;
                case "Teléfono":
                    for (int i = 0; i < arrContactosBorrados.Length; i++)
                    {
                        if (arrContactosBorrados[i] != null)
                        {
                            if (arrContactosBorrados[i].getTelefono().Equals(textBox4.Text))
                            {
                                pos = i;
                                break;
                            }
                        }
                    }
                    mostrarMsg(pos);
                    break;
            }
        }

        // MODIFICADO PARA UD12_PRACT1
        public virtual void mostrarMsg(int pos)
        {
            try
            {
                MessageBox.Show("Contacto encontrado: " + arrContactosBorrados[pos].getNombre() + ", " +
                        arrContactosBorrados[pos].getDireccion() + ", " + arrContactosBorrados[pos].getTelefono());
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Contacto no encontrado.");
            }
        }

        protected void contarContactosBorrados()
        {
            int cont = 0;
            for (int i = 0; i < arrContactosBorrados.Length; i++)
            {
                if (arrContactosBorrados[i] != null)
                {
                    cont++;
                }
            }
            lblContactosBorrados.Text = "Número de contactos borrados: " + cont;
        }

    }


    public class Contacto
    {

        private String nombre;
        private String direccion;
        private String telefono;

        public Contacto(string nombre, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public String getTelefono()
        {
            return this.telefono;
        }

    }
}