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
    public partial class ud04_pract1 : Form
    {
        public ud04_pract1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button1.BackColor = Color.LimeGreen;
            this.button2.BackColor = Color.LimeGreen;
            this.Text = "Primera aplicación";
            this.textBox1.Width += 10;
            this.button2.Width -= 20;
            this.groupBox1.Text = "Primera aplicación";
            this.label1.Text = "Primera aplicación";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ud04_pract1 Reset = new ud04_pract1();
            Reset.Show();
            this.Dispose(false);
        }

    }

}
