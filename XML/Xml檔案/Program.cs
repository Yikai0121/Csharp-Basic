using System;
using System.Xml;

namespace Xml檔案
{
    class Program
    {
        static void Main(string[] args)
        {
            //通過代碼創建XML
            XmlDocument doc = new XmlDocument();
            //創建第一行描述信息
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);


            //創建根結點
            XmlElement books = doc.CreateElement("Books");
            //將根結點添加到文檔中
            doc.AppendChild(books);

            //給根結點Books創建子節點
            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);

            //Book1添加子節點
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "西遊記";
            book1.AppendChild(name1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            book1.AppendChild(price1);

            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "猴子和和尚";
            book1.AppendChild(des1);


            XmlElement book2 = doc.CreateElement("Book");
            books.AppendChild(book2);

            XmlElement name2 = doc.CreateElement("Name");
            name2.InnerText = "紅樓夢";
            book2.AppendChild(name2);

            XmlElement price2 = doc.CreateElement("Price");
            price2.InnerText = "100";
            book2.AppendChild(price2);

            XmlElement des2 = doc.CreateElement("Des");
            des2.InnerText = "賈寶玉";
            book2.AppendChild(des2);


            doc.Save("Books.xml");

        }
    }
}
