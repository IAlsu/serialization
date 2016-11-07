using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlType("book")]
    public class Book
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        private DateTime publish_date;

        [XmlElement("publish_date")]
        public string PublishDate
        {
            get { return publish_date.ToString("yyyy-MM-dd"); }
            set { publish_date = Convert.ToDateTime(value); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        private DateTime registration_date;

        [XmlElement("registration_date")]
        public string RegistrationDate
        {
            get { return registration_date.ToString("yyyy-MM-dd"); }
            set { registration_date = Convert.ToDateTime(value); }
        }
    }

    public enum Genre
    {
        [XmlEnum("Computer")]
        Computer ,
        [XmlEnum("Fantasy")]
        Fantasy ,
        [XmlEnum("Romance")]
        Romance,
        [XmlEnum("Horror")]
        Horror,
        [XmlEnum("Science Fiction")]
        ScienceFiction        
    }

}
