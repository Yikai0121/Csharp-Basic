using System;

namespace Classbasic
{
    public class Person
    {
        //get 將值傳出，當方法調用時使用此方法
        //set 賦於值傳出，當類別實例化時，賦於值  ex: person.Name   _name = value;
        string _name; //欄位須為private 資料儲存作用
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set  
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' || _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }

        public void GetMethod()
        {                                               //取用值在屬性，所以調用屬性的值
            Console.WriteLine("我是{0}今年{1}歲是{2}生", this.Name, this.Age, this.Gender);
        }
    }
}
