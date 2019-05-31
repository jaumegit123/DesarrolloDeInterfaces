using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2 {
    public partial class FormAct4_2 : FormAct4 {
        public FormAct4_2() {
            InitializeComponent();
        }

        public override void btnAgregar_Click(object sender, EventArgs e) {
            if(tbTlf.TextLength != 8)
                MessageBox.Show("El teléfono debe de tener 8 números!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                Contacto c = new Contacto(tbNombre.Text, tbCiudad.Text, tbTlf.Text);

                ListViewItem fila = new ListViewItem(c.getNombre());
                fila.SubItems.Add(c.getCiudad());
                fila.SubItems.Add(c.getTelefono());
                listView1.Items.Add(fila);
            }
            
        }

    }
}
