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
    public class MPPpMaritima
    {
        public bool agregar(BEPmaritima obj)
        {
            try
            {

                XDocument doc = XDocument.Load("XMLpolizas.XML");

                doc.Element("Polizas").Element("PolizasMaritima").Add(new XElement("Poliza",
                                                new XAttribute("ID", Convert.ToString(obj.ID).Trim()),
                                                new XElement("Estado", obj.Estado.Trim()),
                                                new XElement("Prima", Convert.ToString(obj.Prima).Trim()),
                                                new XElement("Tasa", Convert.ToString(obj.Tasa).Trim()),
                                                new XElement("IDcliente", Convert.ToString(obj.Cliente.ID).Trim())));

                doc.Save("XMLpolizas.XML");
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
                XDocument doc = XDocument.Load("XMLpolizas.XML");
                var query = from poli in doc.Descendants("PolizasMaritima").Elements("Poliza")
                            where poli.Attribute("ID").Value == id.Trim()
                            select poli;

                query.Remove();
                doc.Save("XMLpolizas.XML");
            }
            catch (XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

            return true;

        }

        public bool Modificar(BEPmaritima obj)
        {
            try
            {
                XDocument doc = XDocument.Load("XMLpolizas.XML");

                var query = from poli in doc.Descendants("PolizasMaritima").Elements("Poliza")
                            where poli.Attribute("ID").Value == Convert.ToString(obj.ID).Trim()
                            select poli;

                foreach (XElement poli in query)
                {
                    poli.Element("Estado").Value = obj.Estado.Trim();
                    poli.Element("Prima").Value = Convert.ToString(obj.Prima).Trim();
                    poli.Element("Tasa").Value = Convert.ToString(obj.Tasa).Trim();
                    poli.Element("IDcliente").Value = Convert.ToString(obj.Cliente.ID).Trim();
                }

                doc.Save("XMLpolizas.XML");
            }
            catch (XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }


            return true;
        }

        public List<BEPmaritima> Listar()
        {
            try
            {
                MPPcliente mpp = new MPPcliente();

                var query = from poli in XElement.Load("XMLpolizas.XML").Element("PolizasMaritima").Elements("Poliza")
                            select new BEPmaritima
                            {
                                ID = Convert.ToInt32(Convert.ToString(poli.Attribute("ID").Value).Trim()),
                                Estado = Convert.ToString(poli.Element("Estado").Value).Trim(),
                                Prima = Convert.ToDouble(Convert.ToString(poli.Element("Prima").Value).Trim()),
                                Tasa = Convert.ToDouble(Convert.ToString(poli.Element("Tasa").Value).Trim()),
                                Cliente = devolverCliente(mpp.buscar(Convert.ToString(poli.Element("IDcliente").Value).Trim())),
                            };

                List<BEPmaritima> lista = query.ToList<BEPmaritima>();

                if (lista.Count() > 0)
                {
                    return lista;
                }
                else
                {
                    return null;
                }

            }
            catch (XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        private BEcliente devolverCliente(List<BEcliente> list)
        {
            BEcliente client = new BEcliente();
            foreach (BEcliente c in list)
            {
                client = c;
            }

            return client;
        }
    }
}
