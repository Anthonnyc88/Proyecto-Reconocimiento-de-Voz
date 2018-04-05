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

        public void _Añadir_Usuario(string cedula, string nombre,string edad,string sexo, string contraseña,string tU)
        {
            doc.Load(rutaXml);

            XmlNode usuario = _Crear_Usuario(cedula, nombre,edad,sexo, contraseña,tU);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(usuario, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        private XmlNode _Crear_Usuario(string cedula, string nombre,string edad,string sexo, string contraseña,string tU)
        {
            XmlNode usuario = doc.CreateElement("usuario");

            XmlElement xcedula = doc.CreateElement("cedula");
            xcedula.InnerText = cedula;
            usuario.AppendChild(xcedula);

            XmlElement xnombre = doc.CreateElement("nombre");
            xnombre.InnerText = nombre;
            usuario.AppendChild(xnombre);

            XmlElement xedad = doc.CreateElement("edad");
            xedad.InnerText = edad;
            usuario.AppendChild(xedad);

            XmlElement xsexo = doc.CreateElement("sexo");
            xsexo.InnerText = sexo;
            usuario.AppendChild(xsexo);

            XmlElement xcontraseña = doc.CreateElement("contraseña");
            xcontraseña.InnerText = contraseña;
            usuario.AppendChild(xcontraseña);

            XmlElement xtipo_usuario = doc.CreateElement("tipo_usuario");
            xtipo_usuario.InnerText = tU;
            usuario.AppendChild(xtipo_usuario);

            return usuario;
        }

        public string Consulta_Login(string ced,string contr)
        {
            string bandera=String.Empty;
            try
            {
                doc.Load(rutaXml);
                XmlNodeList listaU = doc.SelectNodes("Usuarios/usuario");
                XmlNode user;
                for (int i = 0; i < listaU.Count; i++)
                {
                    user = listaU.Item(i);

                    if ((user.SelectSingleNode("cedula").InnerText == ced) && (user.SelectSingleNode("contraseña").InnerText ==contr))
                    {
                        bandera = user.SelectSingleNode("tipo_usuario").InnerText;
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error \n" + error);
            }
            return bandera;
        }

        public string Retorna_Nombre(int ced)
        {
            string nU = string.Empty;
            try
            {
                doc.Load(rutaXml);
                XmlNodeList listaU = doc.SelectNodes("Usuarios/usuario");
                XmlNode user;
                for (int i = 0; i < listaU.Count; i++)
                {
                    user = listaU.Item(i);

                    if (user.SelectSingleNode("cedula").InnerText == ced.ToString())
                    {
                        nU = user.SelectSingleNode("nombre").InnerText;
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error \n" + error);
            }
            return nU;
        }

        public int Cantidad_Usuarios_Hombres() {

            int cantidadHomb = 0;



            return cantidadHomb;
        }


    }
}
