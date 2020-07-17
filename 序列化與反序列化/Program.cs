using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化與反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person p = new Person();
            // p.Name="富瑜";
            // p.Age = 25;
            // p.Gender = '女';
            // using (FileStream file = new FileStream(@"123.txt", FileMode.OpenOrCreate, FileAccess.Write))
            // {
            //     //序列化對象
            //     BinaryFormatter bf = new BinaryFormatter();
            //     bf.Serialize(file,p); //bf.Serialize(文件流,要序列化的對象)
            // }

            //接收對放發送過來的二進制 反序列化對象
            Person p;
            using (FileStream fsread = new FileStream(@"123.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                 p = (Person)bf.Deserialize(fsread);
                 System.Console.WriteLine(p.Name);
                 System.Console.WriteLine(p.Age);
                 System.Console.WriteLine(p.Gender);
            }
        }
    }
    [Serializable]
    public class Person
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
        private int _age;
        public int Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }

        private char _gender;



    }
}
