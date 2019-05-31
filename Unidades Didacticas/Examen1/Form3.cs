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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void eliminarDuplicados() {
            String str1 = "";
            String str2 = "";

            for (int i = 0; i <= listBox1.Items.Count - 1; i++) {
                str1 = (String)listBox1.Items[i];

                for (int j = (listBox1.Items.Count - 1); j >= (i + 1); j += -1) {
                    str2 = (String)listBox1.Items[j];

                    if (str1.Equals(str2)) {
                        listBox1.Items.RemoveAt(j);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            eliminarDuplicados();
        }
    }
}
