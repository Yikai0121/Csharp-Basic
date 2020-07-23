using System;
using System.Xml;
using System.IO;

namespace 讀取XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Books.xml");


            XmlElement books = doc.DocumentElement;
            //獲得子節點
            XmlNodeList nml = books.ChildNodes;
            foreach (XmlNode item in nml)
            {
                System.Console.WriteLine(item.InnerText);
            }

            
        }
    }
}
