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
    public partial class FormIndice : Form {

        Boolean logoReajustado = false;

        public FormIndice() {
            InitializeComponent();
            pictureBox1.Location = new Point(70, 110);
            pictureBox1.Size = new Size(375, 375);
        }

        private void btnAct1_Click(object sender, EventArgs e) {
            switch(textoAct1.Text){
                case "Modificación de colores y otras propiedades":
                    new ud04_pract1().Show();
                    break;
                case "Formulario de entrada de carácteres, con ListView \ncomo elemento central":
                    new ud5_pract1().Show();
                    break;
                case "Tratamiento de estos datos en forma de \nestructura de datos":
                    new ud6_pract1().Show();
                    break;
                case "Calculo de números primos y el factorial \nde un número":
                    new ud7_pract1().Show();
                    break;
                case "Aplicación MDI":
                    new ud8_pract1().Show();
                    break;
                case "Subprocesos - Threading: Timers y Eventos \nDrag && Drop":
                    new ud9_pract1().Show();
                    break;
                case "Programación de controles en tiempo de ejecución. \nMatriz de controles":
                    new ud10_pract1_form1().Show();
                    break;
                case "Generación de interfaces a partir de documentos XML":
                    new ud11_pract1().Show();
                    break;
                case "Generación de un formulario heredado de entrada de datos":
                    new ud12_pract1().Show();
                    break;
                case "Programación de relojes: Analógico y Digital":
                    new ud13_pract1().Show();
                    break;
                default:
                    break;
            }
        }

        private void btnAct2_Click(object sender, EventArgs e) {
            switch (textoAct2.Text) {
                case "Manejo de items, inserción, cambio y borrado":
                    new ud4_pract2().Show();
                    break;
                case "Paso de valores por valor y por referencia":
                    new ud6_pract2().Show();
                    break;
                case "Threading y Timers":
                    new ud9_pract2().Show();
                    break;
                case "Componente Listview con características de conexión \na documentos XML - Práctica opcional":
                    new ud13_pract2().Show();
                    break;
                default:
                    break;
            }
        }

        private void btnAct3_Click(object sender, EventArgs e) {
            switch (textoAct3.Text) {
                case "Manipulación de ComboBox y ListBox":
                    new ud4_pract3().Show();
                    break;
                case "Hilos y sus respectivas tareas - Práctica opcional":
                    new ud9_pract3_opcional().Show();
                    break;
                default:
                    break;
            }
        }

        private void btnUD4_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = true;
            btnAct3.Visible = true;
            textoAct1.Visible = true;
            textoAct2.Visible = true;
            textoAct3.Visible = true;
            textoAct1.Text = "Modificación de colores y otras propiedades";
            textoAct2.Text = "Manejo de items, inserción, cambio y borrado";
            textoAct3.Text = "Manipulación de ComboBox y ListBox";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD5_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            textoAct1.Visible = true;
            btnAct2.Visible = false;
            btnAct3.Visible = false;
            textoAct2.Visible = false;
            textoAct3.Visible = false;
            textoAct1.Text = "Formulario de entrada de carácteres, con ListView \ncomo elemento central";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD6_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = true;
            btnAct3.Visible = false;
            textoAct1.Visible = true;
            textoAct2.Visible = true;
            textoAct3.Visible = false;
            textoAct1.Text = "Tratamiento de estos datos en forma de \nestructura de datos";
            textoAct2.Text = "Paso de valores por valor y por referencia";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD7_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            textoAct1.Visible = true;
            btnAct2.Visible = false;
            btnAct3.Visible = false;
            textoAct2.Visible = false;
            textoAct3.Visible = false;
            textoAct1.Text = "Calculo de números primos y el factorial \nde un número";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD8_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = false;
            btnAct3.Visible = false;
            textoAct1.Visible = true;
            textoAct2.Visible = false;
            textoAct3.Visible = false;
            textoAct1.Text = "Aplicación MDI";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD9_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = true;
            btnAct3.Visible = true;
            textoAct1.Visible = true;
            textoAct2.Visible = true;
            textoAct3.Visible = true;
            textoAct1.Text = "Subprocesos - Threading: Timers y Eventos \nDrag && Drop";
            textoAct2.Text = "Threading y Timers";
            textoAct3.Text = "Hilos y sus respectivas tareas - Práctica opcional";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD10_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = false;
            btnAct3.Visible = false;
            textoAct1.Visible = true;
            textoAct2.Visible = false;
            textoAct3.Visible = false;
            textoAct1.Text = "Programación de controles en tiempo de ejecución. \nMatriz de controles";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD11_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = true;
            btnAct3.Visible = false;
            textoAct1.Visible = true;
            textoAct2.Visible = true;
            textoAct3.Visible = false;
            textoAct1.Text = "Generación de interfaces a partir de documentos XML";
            textoAct2.Text = "En progreso - Práctica opcional";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD12_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = false;
            btnAct3.Visible = false;
            textoAct1.Visible = true;
            textoAct2.Visible = false;
            textoAct3.Visible = false;
            textoAct1.Text = "Generación de un formulario heredado de entrada de datos";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void btnUD13_Click(object sender, EventArgs e) {
            btnAct1.Visible = true;
            btnAct2.Visible = true;
            btnAct3.Visible = false;
            textoAct1.Visible = true;
            textoAct2.Visible = true;
            textoAct3.Visible = false;
            textoAct1.Text = "Programación de relojes: Analógico y Digital";
            textoAct2.Text = "Componente Listview con características de conexión \na documentos XML - Práctica opcional";
            if (logoReajustado == false) {
                reajustarLogo();
            }
        }

        private void reajustarLogo() {
            pictureBox1.Location = new Point(460, 445);
            pictureBox1.Size = new Size(125, 125);
            logoReajustado = true;
        }

        private void btnExamen1_MouseClick(object sender, MouseEventArgs e) {
            new Examen1.Indice().Show();
        }

        private void btnExamen2_MouseClick(object sender, MouseEventArgs e) {
            // MessageBox.Show("No disponible hasta que lo realice obviamente", "NullPointerException... es broma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Examen2.Indice().Show();
        }
    }
}
