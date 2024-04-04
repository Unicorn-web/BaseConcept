//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson05.泛型编程
//{
//    /*
//     C++模板：模板类 和 模板函数

//    泛型编程：将解决方案和数据类型分离 提取数据类型 数据类型"参数化"
//    让类或函数只注重于解决方案弱化数据类型 同一解决方案应用于多种不同
//    的数据类型 这种思想称为泛型编程。

//        a.泛型函数：
//            定义：返回值类型 函数名<泛型参数>（参数表）{ }

//            使用：函数名(实参表);   ------自动检测泛型参数类型
//                  函数名<数据类型>();

//        b.泛型类：
//            定义： class 类名<泛型参数>{ }
//            使用： 类名<数据类型> 对象 = new 类名<数据类型>();


//        c.泛型约束：
//            1.约束泛型类型为值类型 where T : struct
//            2.约束泛型类型为引用类型 where T : class
//            3.约束泛型类型必须有无参构造函数 where T : new()
//            4.约束泛型类型继承了某个类或接口 where T : 类型 IPerson IComparable

//         */
//    class Main01
//    {
//        //泛型函数  T泛型参数（数据类型产生） Type
//        static void Swap<T>(ref T a,ref T b) 
//        {
//            T t = a;
//            a = b;
//            b = t;
//        }

//        //泛型约束 约束 T 必须是值类型  否则不允许使用
//        static void Swap2<T>(ref T a,ref T b) where T : struct
//        {
//            T t = a;
//            a = b;
//            b = t;
//        }


//        //约束 T 必须是引用类型
//        static void Swap3<T>(ref T a, ref T b) where T : class
//        {
//            T t = a;
//            a = b;
//            b = t;
//        }

//        //约束 T 必须有无参构造函数
//        static void Funtest<T>() where T : new() 
//        {
//            T t = new T();
//        }

//        //约束T  继承了某个类或接口
//        static void FunTest<T>(T obj) where T : IPerson
//        {
//            obj.Eat();
//        }
//        //比较大小
//        static T GetMax<T>(T a,T b) where T : IComparable
//        {
//            return a.CompareTo(b) > 0 ? a : b;
//        }
//        static void Main()
//        {
//            int a = 25, b = 360;
//            float a1 = 2.5f, b1 = 3.14f;
//            Swap(ref a1,ref b1);
//            Swap(ref a,ref b);
//            Console.WriteLine("a1 = {0} b1 = {1}",a1,b1);
//            Console.WriteLine("a = {0} b = {1}",a,b);

//            //构造一个容器
//            CList<int> li = new CList<int>(10);
//            li.Add(100);
//            li.Add(200);
//            li.Add(99);
//            li.Add(88);
//            li.Print();

//            CList<string> li2 = new CList<string>(5);
//            li2.Add("古力娜扎");
//            li2.Add("玛尔扎哈");
//            li2.Add("迪丽热巴");
//            li2.Add("米米拉哈");
//            li2.Print();

//            Swap2(ref a,ref b);

//            Hero h1 = new Hero();
//            Hero h2 = new Hero();
//            //Swap2(ref h1, ref h2);//约束必须值类型，h1,h2是引用类型 这个报错
//            Swap(ref h1, ref h2);//约束必须值类型 这个不报错


//            int n1 = 1, n2 = 2;
//            //Swap3(ref n1, ref n2);//约束必须是引用类型 报错
//            Swap3(ref h1, ref h2);//约束必须是引用类型 不报错

//            //Funtest<Student>(); //这个报错 Student没有无参构造函数
//            //Funtest<Hero>();    //不报错

//            //FunTest(new Hero());        // 没报错
//            //FunTest(new Student(10));  //报错 因为Student没有继承IPerson接口

//            //练习：定义一个比较大小函数GetMax      
//            //使用泛型 可以比较任意数据类型的 大小 返回较大者

//            int a2 = 20, b2 = 3;
//            //int max =  a2 > b2 ? a2 : b2;

//            float f1 = 3.2f, f2 = 3.33f;
//            Console.WriteLine(GetMax<int>(a2, b2)) ;
//            Console.WriteLine(GetMax(f1, f2));
//            Student s = GetMax(new Student(1000), new Student(20)); //新的类不是内置类型，必须继承IComparable接口，然后重写Compareto函数里面要包含Student的比较
//            Console.WriteLine(s.id);



//        }
//    }
//}
