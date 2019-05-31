using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidades_Didacticas {
    public partial class RelojDigital : UserControl {

        private string dia;

        public RelojDigital() {
            InitializeComponent();

            timer1.Start();
        }

        #region Propiedades
        public new bool Enabled {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; }
        }

        public new bool Visible {
            get { return panel1.Visible; }
            set { panel1.Visible = value; }
        }

        public Color InnerColor {
            get { return circularProgressBar1.InnerColor; }
            set { circularProgressBar1.InnerColor = value; }
        }
        #endregion Propiedades

        private void timer1_Tick(object sender, EventArgs e) {
            lblSegundos.Text = DateTime.Now.ToString("ss");
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            // Para poner la primera letra en mayúsculas
            dia = DateTime.Now.ToString("dddd");
            lblDia.Text = dia.Substring(0, 1).ToUpper() + dia.Substring(1, dia.Length - 1);
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Para que la barra circular vaya aumentando el valor
            circularProgressBar1.Value = Convert.ToInt32(lblSegundos.Text);
        }
    }
}
