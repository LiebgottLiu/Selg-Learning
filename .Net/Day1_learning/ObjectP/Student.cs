using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectP
{
    public class Student
    {


        // 构造函数
        public Student() { 
            
        }

        //析构函数
        ~Student() {
            Console.WriteLine("process at the end of the program");
        }






        private string _name;

        public string Name { get { return _name; } set { _name = value; } }

        private int _age;
        public int Age { get { return _age; } set {
                if (value < 0 || value > 100) {
                    value = 0;
                }
                _age = value; } }

        private char _gender;
        public char Gender { get {
                if (_gender != 'M' && _gender != 'F') { 
                    return _gender = 'M';
                }
                return _gender; } set { _gender = value; } }

        private int _chinese;
        public int Chinese { get { return _chinese; } set { _chinese = value; } }

        private int _math;
        public int math { get { return _math; } set { _math = value; } }

        private int _eng;
        public int Geng { get { return _eng; } set { _eng = value; } }

        public void SayHello() {
            Console.WriteLine("I am {0}, I am {1} Years old, I am {2} brom", this._name, this._age, this._gender);
        }

        public void showScore() { 
            Console.WriteLine("I am {0}, My total score is {1}, average score is {2}", this._name, (this._math + this._chinese + this._eng), (this._math+this._chinese+this._eng)/3  );
        }

    }
}
