using System;
using System.Xml;
using System.IO;

namespace 追加xlm
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement books;
            if (File.Exists("Books.xml"))
            {
                doc.Load("Books.xml");
                books = doc.DocumentElement;
            }
            else
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                books = doc.CreateElement("Books");
                doc.AppendChild(books);

                XmlElement book1 = doc.CreateElement("Book");
                books.AppendChild(book1);

                //Book1添加子節點
                XmlElement name1 = doc.CreateElement("Name");
                name1.InnerText = "西遊記V2";
                book1.AppendChild(name1);

                XmlElement price1 = doc.CreateElement("Price");
                price1.InnerText = "10000";
                book1.AppendChild(price1);

                XmlElement des1 = doc.CreateElement("Des");
                des1.InnerText = "猴子和和尚V2";
                book1.AppendChild(des1);





                doc.Save("Books.xml");
            }
        }
    }
}
