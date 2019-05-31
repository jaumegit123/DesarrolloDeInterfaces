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
    public partial class ud10_pract1_form1 : Form {

        public ud10_pract1_form1() {
            InitializeComponent();
            cmbTipo.SelectedIndex = 2;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cmbTipo.SelectedIndex) {
                case 0:
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Nombre", 130, HorizontalAlignment.Center);
                    listView1.Columns.Add("Dirección", 180, HorizontalAlignment.Center);
                    break;
                case 1:
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Nombre", 130, HorizontalAlignment.Center);
                    listView1.Columns.Add("Dirección", 180, HorizontalAlignment.Center);
                    listView1.Columns.Add("Email", 180, HorizontalAlignment.Center);
                    break;
                case 2:
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Nombre", 130, HorizontalAlignment.Center);
                    listView1.Columns.Add("Dirección", 180, HorizontalAlignment.Center);
                    listView1.Columns.Add("Email", 180, HorizontalAlignment.Center);
                    listView1.Columns.Add("Teléfono", 120, HorizontalAlignment.Center);
                    break;
            }
        }

        private void btnAnyadirDatos_Click(object sender, EventArgs e) {
            new ud10_pract1_form2(this).Show();
        }

    }
}
