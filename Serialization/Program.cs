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
            SerializeAndDeserialize();
            Console.ReadLine();
        }

        static void SerializeAndDeserialize()
        {
            var serializer = new XmlSerializer(typeof(Catalog));
            
            // Десериализация существующего файла "books.xml" в папке ...\bin\Debug проекта
            Console.WriteLine("Start deserialization");
            var catalog = serializer.Deserialize(
                new FileStream("books.xml", FileMode.Open)) as Catalog;
            Console.WriteLine("Deserialization of the file ...\\bin\\Debug\\books.xml finished");

            //Сериализация в файл "books_deserialized.xml" в папке ...\bin\Debug проекта
            Console.WriteLine("Start Serialization");
            var stream = new FileStream("books_deserialized.xml", FileMode.Create);
            serializer.Serialize(stream, catalog);
            Console.WriteLine("Serialization finished (...\\bin\\Debug\\books1.xml)");

            stream.Close();
        }
    }
}
