using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            Catalog c = new Catalog();
            c.catalog = new Catalog.Book[]
            { new Catalog.Book 
                                { 
                                Isbn = "0 - 596 - 00103 - 7",
                                Author = "Löwy, Juval",
                                Title = "COM and .NET Component Services",
                                Genre = "Computer",
                                Publisher = "O'Reilly",
                                PublishDate =DateTime.Now.ToString("yyyy-MM-dd"),
                                Description = "...",
                                RegistrationDate = DateTime.Now.ToString("yyyy-MM-dd")
                                } }  ;

            //("yyyy-MM-dd");
            var serializer = new XmlSerializer(typeof(Catalog));
            var stream = new FileStream("books.xml", FileMode.Create);
            serializer.Serialize(stream, c); stream.Close();


            serializer = new XmlSerializer(typeof(Catalog));
            var person = serializer.Deserialize(
                new FileStream("books.xml", FileMode.Open)) as Catalog;

            Console.ReadLine();
        }
    }
}
