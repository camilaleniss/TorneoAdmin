using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public static class SerializacionXML<T>
    {
        public static object Deserializar(XmlDocument xml, Type type)
        {
            XmlSerializer s = new XmlSerializer(type);
            string xmlString = xml.OuterXml.ToString();
            byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
            MemoryStream ms = new MemoryStream(buffer);
            XmlReader reader = new XmlTextReader(ms);
            object o = null;
            try
            {
                o = s.Deserialize(reader);
            }
            finally
            {
                reader.Close();
            }
            return o;
        }

        public static T Deserializar<T>(XmlDocument xml)
        {
            return (T)Deserializar(xml, typeof(T));
        }

        public static XmlDocument Serializar(object o)
        {
            XmlSerializer s = new XmlSerializer(o.GetType());
            XmlDocument xml = null;
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, new UTF8Encoding());
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = ' ';
            writer.Indentation = 5;

            try
            {
                s.Serialize(writer, o);
                xml = new XmlDocument();
                string xmlString = ASCIIEncoding.UTF8.GetString(ms.ToArray());
                xml.LoadXml(xmlString);
            }
            finally
            {
                writer.Close();
                ms.Close();
            }
            return xml;
        }

    }
}
