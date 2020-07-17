using System;
namespace InheritanceLesson
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public Person(string name,string id,string gender)
        {
            this.Name = name;
            this.Id = id;
            this.Gender = gender;
        }

        public void Eat()
        {
            System.Console.WriteLine("I can eat");
        }
        public void Drink()
        {
            System.Console.WriteLine("Eat");
        }
        
    }
}
