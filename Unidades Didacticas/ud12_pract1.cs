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
    public partial class ud12_pract1 : ud6_pract1 {

        public ud12_pract1() {
            InitializeComponent();
        }

        // Solo admitimos nombres que comiencen por la P:
        public override void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                if (!textBox1.Text.Substring(0, 1).Equals("P")) {
                    lblAvisoNombre.Visible = true;
                    lblAvisoNombre.Text = "El nombre solo puede empezar por la letra P";
                } else {
                    lblAvisoNombre.Visible = false;
                }
                comprobar();
            } catch (ArgumentOutOfRangeException) { }
        }

        // En la clase padre no permitimos reingreso, en esta sí:
        public override void mostrarMsg(int pos) {
            try {
                if (MessageBox.Show("Contacto encontrado: " + arrContactosBorrados[pos].getNombre() + ", " +
                        arrContactosBorrados[pos].getDireccion() + ", " + arrContactosBorrados[pos].getTelefono() +
                            "\n¿Quieres añadir el item borrado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                    ListViewItem lista = new ListViewItem(arrContactosBorrados[pos].getNombre());
                    lista.SubItems.Add(arrContactosBorrados[pos].getDireccion());
                    lista.SubItems.Add(arrContactosBorrados[pos].getTelefono());
                    listView1.Items.Add(lista);
                    arrContactosBorrados[pos] = null;
                    contarContactosBorrados();
                }
            } catch (IndexOutOfRangeException) {
                MessageBox.Show("Contacto no encontrado");
            }
        }

    }
}
