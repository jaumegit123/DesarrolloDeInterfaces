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
    public partial class FormAct4 : Form {
        public FormAct4() {
            InitializeComponent();
        }

        public virtual void btnAgregar_Click(object sender, EventArgs e) {
            Contacto c = new Contacto(tbNombre.Text, tbCiudad.Text, tbTlf.Text);

            ListViewItem fila = new ListViewItem(c.getNombre());
            fila.SubItems.Add(c.getCiudad());
            fila.SubItems.Add(c.getTelefono());
            listView1.Items.Add(fila);
        }
    }
}

public class Contacto {

    private String nombre;
    private String ciudad;
    private String telefono;

    public Contacto(string nombre, string ciudad, string telefono) {
        this.nombre = nombre;
        this.ciudad = ciudad;
        this.telefono = telefono;
    }

    public String getNombre() {
        return this.nombre;
    }

    public String getCiudad() {
        return this.ciudad;
    }

    public String getTelefono() {
        return this.telefono;
    }

}