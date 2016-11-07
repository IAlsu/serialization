using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlType("catalog")]
    public class Catalog
    {
        private DateTime date;

        [XmlAttribute("date")]
        public string Date
        {
            get { return date.ToString("yyyy-MM-dd"); }
            set { date = Convert.ToDateTime(value); }
        }

        [XmlArray("books")]
        [XmlArrayItem("book")]
        public List<Book> Books { get; set; }

        public Catalog()
        {
            Books = new List<Book>();
        }
    }


}
