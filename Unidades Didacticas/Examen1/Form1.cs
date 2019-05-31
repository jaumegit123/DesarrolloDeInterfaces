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
    public partial class Form1 : Form {

        static List<TablaWindsurf> listaTablas = new List<TablaWindsurf>();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBoxModelo.TextLength == 0 || textBoxTipo.TextLength == 0 || textBoxPrecio.TextLength == 0) {
                MessageBox.Show("Has de llenar los 3 campos!");
            } else {
                listaTablas.Add(new TablaWindsurf(textBoxModelo.Text, textBoxTipo.Text, textBoxPrecio.Text));

                ListViewItem lista = new ListViewItem(listaTablas.ElementAt(listaTablas.Count - 1).getModelo());
                lista.SubItems.Add(listaTablas.ElementAt(listaTablas.Count - 1).getTipo());
                lista.SubItems.Add(listaTablas.ElementAt(listaTablas.Count - 1).getPrecio());
                listView1.Items.Add(lista);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                listView1.FocusedItem = listView1.FindItemWithText(textBoxBusqueda.Text);
                listView1.FindItemWithText(textBoxBusqueda.Text).Selected = true;
                listView1.Select();
            } catch (NullReferenceException) {

            }
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                listView1.FocusedItem.Remove();
            } catch (NullReferenceException) {

            }
        }
    }

    public class TablaWindsurf {

        private String modelo;
        private String tipo;
        private String precio;

        public TablaWindsurf(string modelo, string tipo, string precio) {
            this.modelo = modelo;
            this.tipo = tipo;
            this.precio = precio;
        }

        public String getModelo() {
            return this.modelo;
        }

        public String getTipo() {
            return this.tipo;
        }

        public String getPrecio() {
            return this.precio;
        }

    }
}