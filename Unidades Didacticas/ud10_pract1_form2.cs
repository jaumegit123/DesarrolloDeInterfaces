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
    public partial class ud10_pract1_form2 : Form {

        ud10_pract1_form1 form1;

        public ud10_pract1_form2(ud10_pract1_form1 form1) {
            InitializeComponent();

            this.form1 = form1;

            switch (this.form1.cmbTipo.SelectedIndex) {
                case 0:
                    lblEmail.Visible = false;
                    lblTlf.Visible = false;
                    tbEmail.Visible = false;
                    tbTlf.Visible = false;
                    break;
                case 1:
                    lblTlf.Visible = false;
                    tbTlf.Visible = false;
                    break;
                case 2:
                    // No hacemos nada porqué en esta opción se construyen los campos para las 4 columnas.
                    break;
            }

        }

        private void btnEnviarDatos_Click(object sender, EventArgs e) {
            ListViewItem lista = new ListViewItem(tbNombre.Text);
            lista.SubItems.Add(tbDireccion.Text);
            lista.SubItems.Add(tbEmail.Text);
            lista.SubItems.Add(tbTlf.Text);
            lista.Font = new Font(this.form1.listView1.Columns[0].ListView.Font, FontStyle.Regular);
            this.form1.listView1.Items.Add(lista);
            this.Close();
        }

    }
}
