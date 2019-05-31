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

namespace Examen2 {
    public partial class FormAct1 : Form {

        private const string fichXML = "usuariosExamen2.xml";
        private static XmlDocument doc = new XmlDocument();
        private static XmlNodeList usuarios;
        private static XmlNodeList usuario;
        private static int autoincrementID = 0;

        public FormAct1() {
            InitializeComponent();

            doc.Load(fichXML);

            usuarios = doc.GetElementsByTagName("usuarios");
            usuario = ((XmlElement)usuarios[0]).GetElementsByTagName("usuario");

            foreach (XmlElement node in usuario) {
                XmlNodeList id = node.GetElementsByTagName("id");
                XmlNodeList nombre = node.GetElementsByTagName("nombre");
                XmlNodeList ciudad = node.GetElementsByTagName("ciudad");
                XmlNodeList edad = node.GetElementsByTagName("edad");

                listBox1.Items.Add(nombre.Item(0).Name + " " + ciudad.Item(0).Name + " " + edad.Item(0).Name);
                autoincrementID = Int32.Parse(id.Item(0).InnerText);
            }
        }

        private void btnProcedimiento1_Click(object sender, EventArgs e) {
            foreach (XmlElement node in usuario) {

                XmlNode id = node.SelectSingleNode("id");

                if (Int32.Parse(id.InnerText) % 2 != 0) {
                    XmlNode edad = node.SelectSingleNode("edad");
                    edad.InnerText = "50";
                    MessageBox.Show("Valores cambiados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            doc.Save(fichXML);
        }

        private void btnProcedimiento2_Click(object sender, EventArgs e) {
            XmlElement usuario = doc.CreateElement("usuario");
            XmlElement ID = doc.CreateElement("id");
            XmlElement nom = doc.CreateElement("nombre");
            XmlElement ciu = doc.CreateElement("ciudad");
            XmlElement edad = doc.CreateElement("edad");

            doc.DocumentElement.AppendChild(usuario);
            usuario.AppendChild(ID);
            usuario.AppendChild(nom);
            usuario.AppendChild(ciu);
            usuario.AppendChild(edad);

            ID.InnerText = (++autoincrementID).ToString();
            nom.InnerText = "Jutta";
            ciu.InnerText = "Ulm";
            edad.InnerText = "45";

            doc.Save(fichXML);
        }
    }
}
