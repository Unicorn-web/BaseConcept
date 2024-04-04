using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.泛型编程
{
    class Hero : IPerson
    {
        public string name;

        public void Eat()
        {
            Console.WriteLine("吃饭...");
        }
    }

    class Student : IComparable //此类没有 无参构造
    {
        public int id;
        public Student(int id)
        {
            this.id = id;
        }
        // Student类型的CompareTo函数，与IComparable中的Compareto函数可以根据不同类型如Student，int，float，实现不同的CompareTo函数
        public int CompareTo(object obj)
        {
            Student s = obj as Student;
            return this.id > s.id ? 1 : -1;
        }


    }
}
