using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Capa_Datos
{
    public class XML_Carros
    {
        string rutaXml = "Automoviles.xml";
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

        public void _Añadir_Automovil(string placa, string f_p,string nombre_conductor)
        {
            doc.Load(rutaXml);

            XmlNode auto = _Crear_Automovil(placa, f_p,nombre_conductor);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(auto, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        private XmlNode _Crear_Automovil(string placa, string fecha_parqueo,string nc)
        {
            XmlNode auto = doc.CreateElement("automovil");

            XmlElement xplaca = doc.CreateElement("placa");
            xplaca.InnerText = placa;
            auto.AppendChild(xplaca);

            XmlElement xfecha_parqueo = doc.CreateElement("fecha_parqueo");
            xfecha_parqueo.InnerText = fecha_parqueo;
            auto.AppendChild(xfecha_parqueo);

            XmlElement xnombre_conductor = doc.CreateElement("nombre_conductor");
            xnombre_conductor.InnerText = nc;
            auto.AppendChild(xnombre_conductor);

            return auto;
        }
    }
}
