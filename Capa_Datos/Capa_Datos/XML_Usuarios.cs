using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Capa_Datos
{
    public class XML_Usuarios
    {
        string rutaXml = "Usuarios.xml";
        XmlDocument doc = new XmlDocument();

        public void _crearXml(string ruta, string nodoRaiz)
        {
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlNode element1 = doc.CreateElement(nodoRaiz);
            doc.AppendChild(element1);
            doc.Save(ruta);
        }

        public void _Añadir_Usuario(string cedula, string nombre,int edad,string sexo, string contraseña)
        {
            doc.Load(rutaXml);

            XmlNode usuario = _Crear_Usuario(cedula, nombre,edad,sexo, contraseña);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(usuario, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        private XmlNode _Crear_Usuario(string cedula, string nombre,int edad,string sexo, string contraseña)
        {
            XmlNode usuario = doc.CreateElement("usuario");

            XmlElement xcedula = doc.CreateElement("cedula");
            xcedula.InnerText = cedula;
            usuario.AppendChild(xcedula);

            XmlElement xnombre = doc.CreateElement("nombre");
            xnombre.InnerText = nombre;
            usuario.AppendChild(xnombre);

            XmlElement xedad = doc.CreateElement("edad");
            xedad.InnerText = nombre;
            usuario.AppendChild(xedad);

            XmlElement xsexo = doc.CreateElement("sexo");
            xedad.InnerText = sexo;
            usuario.AppendChild(xsexo);

            XmlElement xcontraseña = doc.CreateElement("contraseña");
            xcontraseña.InnerText = contraseña;
            usuario.AppendChild(xcontraseña);

            return usuario;
        }

        public bool Consulta_Login(TextBox txt1, TextBox txt2)
        {
            bool bandera = false;
            try
            {
                doc.Load(rutaXml);
                XmlNodeList listaU = doc.SelectNodes("Usuarios/usuario");
                XmlNode user;
                for (int i = 0; i < listaU.Count; i++)
                {
                    user = listaU.Item(i);

                    if ((user.SelectSingleNode("cedula").InnerText == txt1.Text) && (user.SelectSingleNode("contraseña").InnerText == txt2.Text))
                    {
                        bandera = true;
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error \n" + error);
            }
            return bandera;
        }
    }
}
