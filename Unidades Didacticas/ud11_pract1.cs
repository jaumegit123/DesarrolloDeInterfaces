using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Unidades_Didacticas {
    public partial class ud11_pract1 : Form {

        private const string fichXML = "usuarios.xml";
        private static XmlDocument doc = new XmlDocument();
        private static int autoincrementID = 0;

        public ud11_pract1() {
            InitializeComponent();

            // Al cargar el Form, intentamos cargar el fichero xml y actualizar el ListView
            try {
                doc.Load(fichXML);
                actualizarListView();
            } catch (System.IO.FileNotFoundException) { // Si no existe, lo creamos y luego lo cargamos, dejándolo listo para la inserción de datos
                crearXML();
                doc.Load(fichXML);
            }
        }

        private void crearXML() {
            XmlWriterSettings xmlws = new XmlWriterSettings();
            xmlws.Indent = true;

            XmlWriter writer = XmlWriter.Create(fichXML, xmlws);

            writer.WriteStartElement("usuarios");
            writer.WriteEndElement();
            writer.Close();
        }

        private void actualizarListView() {
            listView1.Clear();
            Boolean crearColumnas = true;

            XmlNodeList personas = doc.GetElementsByTagName("usuarios");
            XmlNodeList lista = ((XmlElement)personas[0]).GetElementsByTagName("usuario");

            foreach (XmlElement node in lista) {
                XmlNodeList id = node.GetElementsByTagName("id");
                XmlNodeList nombre = node.GetElementsByTagName("nombre");
                XmlNodeList apellidos = node.GetElementsByTagName("apellidos");
                XmlNodeList ciudad = node.GetElementsByTagName("ciudad");
                XmlNodeList telefono = node.GetElementsByTagName("tlf");

                if (crearColumnas) {
                    listView1.Columns.Add(id.Item(0).Name, 30, HorizontalAlignment.Center);
                    listView1.Columns.Add(nombre.Item(0).Name, 130, HorizontalAlignment.Center);
                    listView1.Columns.Add(apellidos.Item(0).Name, 200, HorizontalAlignment.Center);
                    listView1.Columns.Add(ciudad.Item(0).Name, 120, HorizontalAlignment.Center);
                    listView1.Columns.Add(telefono.Item(0).Name, 120, HorizontalAlignment.Center);
                    crearColumnas = false;
                }

                // Insertamos los datos
                ListViewItem fila = new ListViewItem(id.Item(0).InnerText);
                fila.SubItems.Add(nombre.Item(0).InnerText);
                fila.SubItems.Add(apellidos.Item(0).InnerText);
                fila.SubItems.Add(ciudad.Item(0).InnerText);
                fila.SubItems.Add(telefono.Item(0).InnerText);
                fila.Font = new Font(listView1.Columns[0].ListView.Font, FontStyle.Regular);
                listView1.Items.Add(fila);

                // Asignamos el autoincrementador al último id del fichero xml
                autoincrementID = Int32.Parse(id.Item(0).InnerText); 
            }
        }

        private void bActualizar_Click(object sender, EventArgs e) {
            actualizarListView();
        }

        private void btnInsertarEnXML_Click(object sender, EventArgs e) {
            XmlElement usuario = doc.CreateElement("usuario");
            XmlElement ID = doc.CreateElement("id");
            XmlElement nom = doc.CreateElement("nombre");
            XmlElement ape = doc.CreateElement("apellidos");
            XmlElement ciu = doc.CreateElement("ciudad");
            XmlElement tlf = doc.CreateElement("tlf");

            doc.DocumentElement.AppendChild(usuario);
            usuario.AppendChild(ID);
            usuario.AppendChild(nom);
            usuario.AppendChild(ape);
            usuario.AppendChild(ciu);
            usuario.AppendChild(tlf);

            ID.InnerText = (++autoincrementID).ToString();
            nom.InnerText = tbNombre.Text;
            ape.InnerText = tbApellidos.Text;
            ciu.InnerText = tbCiudad.Text;
            tlf.InnerText = tbTlf.Text;

            doc.Save(fichXML);
        }
    }
}
