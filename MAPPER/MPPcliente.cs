using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using BE;

namespace MAPPER
{
    public class MPPcliente
    {
        public bool Agregar(BEcliente obj)
        {
            try
            {
                XDocument doc = XDocument.Load("XMLclientes.XML");

                doc.Element("Clientes").Add(new XElement("Cliente", 
                                        new XAttribute("ID",Convert.ToString(obj.ID).Trim()),
                                        new XElement("Nombre", obj.Nombre.Trim()),
                                        new XElement("Apellido", obj.Apellido.Trim()),
                                        new XElement("Dni", Convert.ToString(obj.Dni).Trim())));

                doc.Save("XMLclientes.XML");
            }
            catch (XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

            return true;
        }

        public bool Eliminar(string id)
        {
            try
            {
                XDocument doc = XDocument.Load("XMLclientes.XML");

                var query = from cliente in doc.Descendants("Clientes").Elements("Cliente")
                            where (string)cliente.Attribute("ID").Value == id.Trim()
                            select cliente;

                query.Remove();
                doc.Save("XMLclientes.XML");

            }
            catch (XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

            return true;

        }

        public bool Modificar(BEcliente obj)
        {
            XDocument doc = XDocument.Load("XMLclientes.XML");

            var query = from cliente in doc.Descendants("Clientes").Elements("Cliente")
                        where cliente.Attribute("ID").Value == Convert.ToString(obj.ID)
                        select cliente;

            foreach (XElement clien in query)
            {
                clien.Element("Nombre").Value = obj.Nombre.Trim();
                clien.Element("Apellido").Value = obj.Apellido.Trim();
                clien.Element("Dni").Value = Convert.ToString(obj.Dni).Trim();
            }

            doc.Save("XMLclientes.XML");
            return true;
        }

        public List<BEcliente> Listar()
        {
            var query = from cliente in XElement.Load("XMLclientes.XML").Elements("Cliente")
                        select new BEcliente
                        {
                            ID = Convert.ToInt32(Convert.ToString(cliente.Attribute("ID").Value).Trim()),
                            Nombre = Convert.ToString(cliente.Element("Nombre").Value).Trim(),
                            Apellido = Convert.ToString(cliente.Element("Apellido").Value).Trim(),
                            Dni = Convert.ToInt32(Convert.ToString(cliente.Element("Dni").Value).Trim()),
                        };

            List<BEcliente> lista = query.ToList<BEcliente>();
            return lista;
             
        }

        public List<BEcliente> buscar(string id)
        {

            var query = from cliente in XElement.Load("XMLclientes.XML").Elements("Cliente")
                        where (string)cliente.Attribute("ID") == id.Trim()
                        select new BEcliente
                        {
                            ID = Convert.ToInt32(Convert.ToString(cliente.Attribute("ID").Value).Trim()),
                            Nombre = Convert.ToString(cliente.Element("Nombre").Value).Trim(),
                            Apellido = Convert.ToString(cliente.Element("Apellido").Value).Trim(),
                            Dni = Convert.ToInt32(Convert.ToString(cliente.Element("Dni").Value).Trim()),
                        };

            List<BEcliente> lista = query.ToList<BEcliente>();
            return lista;

        }
    }
}
