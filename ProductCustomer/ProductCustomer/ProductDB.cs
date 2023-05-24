using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CustomerProductClasses
{
    public static class ProductDB
    {
        private const string Path = @"..\..\..\data\Products.xml";

        public static List<Product> GetProducts()
        {
            // create the list
            List<Product> products = new List<Product>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Product node
            if (xmlIn.ReadToDescendant("Product"))
            {
                // create one Product object for each Product node
                do
                {
                    Product product = new Product();
                    xmlIn.ReadStartElement("Product");
                    product.Id = xmlIn.ReadElementContentAsInt();
                    product.Code = xmlIn.ReadElementContentAsString();
                    product.Description = xmlIn.ReadElementContentAsString();
                    product.UnitPrice = xmlIn.ReadElementContentAsDecimal();
                    product.QuantityOnHand = xmlIn.ReadElementContentAsInt();
                    products.Add(product);
                }
                while (xmlIn.ReadToNextSibling("Product"));
            }

            // close the XmlReader object
            xmlIn.Close();

            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Products");

            // write each product object to the xml file
            foreach (Product product in products)
            {
                xmlOut.WriteStartElement("Product");
                xmlOut.WriteElementString("Id", product.Id.ToString());
                xmlOut.WriteElementString("Code", product.Code);
                xmlOut.WriteElementString("Description", product.Description);
                xmlOut.WriteElementString("UnitPrice", Convert.ToString(product.UnitPrice));
                xmlOut.WriteElementString("QuantityOnHand", product.QuantityOnHand.ToString());
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}
