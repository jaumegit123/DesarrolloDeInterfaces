﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidades_Didacticas.Examen1 {
    public partial class Indice : Form {
        public Indice() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            new Form2().Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            new Form3().Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            new Form4().Show();
        }
    }
}
