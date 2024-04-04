using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.泛型编程
{
    /*
        设计一个容器类型 可以保存多个数据

        思想：使用泛型编程 将存储的数据类型提取出来
        让一个容器存储逻辑 不关注数据类型只观察数据的
        存储逻辑 数据类型参数化 让类适应于多种不同类型的数据
        存储。
         
         */
    class CList<T>
    {
        T[] arr;//用于存储数据的容器（数组）
        int size;//记录存储的数据个数
        int maxSize;//最大容器

        public CList(int _maxSize)
        {
            maxSize = _maxSize;
            arr = new T[maxSize];
            size = 0;
        }

        public void Add(T _data)
        {
            if (size == maxSize)
            {
                return;
            }
            arr[size++] = _data;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


    }
}
