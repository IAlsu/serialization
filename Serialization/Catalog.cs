using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlRoot("catalog")]
    public class Catalog
    {
        [XmlRoot("book")]
        public class Book
        {
            [XmlElement("isbn")]
            public string Isbn { get; set; }

            [XmlElement("author")]
            public string Author { get; set; }

            [XmlElement("title")]
            public string Title { get; set; }

            [XmlElement("genre")]
            public string Genre { get; set; }

            [XmlElement("publisher")]
            public string Publisher { get; set; }

            [XmlElement("publish_date")]
            public string PublishDate { get; set; }

            [XmlElement("description")]
            public string Description { get; set; }

            [XmlElement("registration_date")]
            public string RegistrationDate { get; set; }
        }

        //[XmlArray("catalog")]
        [XmlArrayItem("book")]
        public Book[] catalog { get; set; }
    }
}
