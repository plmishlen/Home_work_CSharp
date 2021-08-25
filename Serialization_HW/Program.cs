using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Program
    {
        [Serializable]
        public class Books
        {
            public Books(string title, int release)
            {
                Title = title;
                Release = release;
            }
            public Books() { }
            public string Title { get; set; }
            public int Release { get; set; }
            [NonSerialized]
            public List<Books> Book = new List<Books>();
        }

        static void Main(string[] args)
        {
            Books
            p1 = new Books("Война и мир", 1865),
            p2 = new Books("Евгений Онегин", 1831),
            p3 = new Books("Преступление и наказание", 1866),
            p4 = new Books("Мастер и маргарита", 1937);
          
            List<Books> Books1 = new List<Books>() { p1, p2, p3, p4 };
            List<Books> Books2;


            JsonSerializer jsonSerializer = new JsonSerializer();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Books>));

            using (Stream fs = new FileStream("book.json", FileMode.OpenOrCreate))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(new StreamWriter(fs)))
                {
                    jsonSerializer.Serialize(jsonWriter, Books1);
                }
            }

            using (Stream fs = new FileStream("book.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, Books1);
            }

            Books1 = null;

            using (Stream fs = new FileStream("book.json", FileMode.Open))
            {
                using (JsonReader jsonReader = new JsonTextReader(new StreamReader(fs)))
                {
                    Books1 = jsonSerializer.Deserialize(jsonReader, typeof(List<Books>)) as List<Books>;
                }
            }
            using (Stream fs = new FileStream("book.xml", FileMode.Open))
            {

                Books2 = xmlSerializer.Deserialize(fs) as List<Books>;
            }

            ReadKey();
        }
    }
}

