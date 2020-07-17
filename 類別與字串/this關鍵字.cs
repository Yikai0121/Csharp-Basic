using System;

namespace Classbasic
{
    public class Student
    {
        string _name;
        public string Name { get; set; }

        int _age;
        public int Age { get; set; }
        char _gender;
        public char Gender { set; get; }
        int _score;
        public int Score { get; set; }
        public Student(string name, int age, char gender, int score)
        {
            this.Name = _name;
            this.Age = _age;

        }
        //調用上方構造函數
        public Student(string name, int age, char gender) : this(name, age, gender, 0)
        {

        }
        public Student()
        {

        }
    }

}

