//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson05.事件和委托
//{
//    /*
//     委托：委托是C#一种自定义数据类型 该类型可以保存函数地址 使用委托类型变量
//     可以将一个函数作为参数传递 或者 使用委托变量批量调用多个函数. -----与C++函数指针相似

//        委托类型定义：
//             delegate 返回值类型 委托类型名(参数表);

//        委托变量使用：
//              委托类型名 变量名;

//        支持操作： +=  ，-= , =
            

//     事件：是基于委托定义的一种变量 本质就是一个委托变量 是委托变量的一种保护使用方式
//     C#官方提出 使用事件 比使用委托更安全。

//        事件定义：
//            event 委托类型 事件名;

//        区别：
//            1.委托变量支持 = 运算符 有极大的不安全性  =有覆盖操作
//              事件不支持 = 运算符 极大的提高 安全性 (只允许定义事件的本类使用 =)

//            2.委托变量支持类外 进行触发绑定函数
//              事件变量只支持类中进行触发  提高了 事件触发源头的确定性  （是谁定义的事件 就由谁去触发该事件 更加安全可靠）
         
//      */
//    delegate void Action1();//定义一个委托类型 类型名为Action1  
//                            //该类型定义的变量可以保存 返回值为void 参数表为空的函数地址
//    class Main2
//    {
//        static Action1 btnCLick;//普通委托变量
//        static event Action1 btnOnEnter;//修饰的委托变量  （事件）
//        static void FunTest()
//        {
//            Console.WriteLine("FunTest is  call ...");
//        }
//        static void FunTest2()
//        {
//            Console.WriteLine("FunTest2 is  call ...");
//        }
//        static void FunTest3()
//        {
//            Console.WriteLine("FunTest3 is  call ...");
//        }

//        static void Move()
//        {
//            Console.WriteLine("移动物体");
//        }
//        static void Rotate()
//        {
//            Console.WriteLine("旋转物体");
//        }
//        static void Scale()
//        {
//            Console.WriteLine("放大物体");
//        }

//        //点击一个按钮执行一系列函数 n个不确定 函数
//        static void OnButtonClicked()
//        {
//            Console.WriteLine("鼠标点击执行逻辑：");
//            btnCLick();
//        }

//        static void Main()
//        {

//            Action1 fun;//定义一个委托变量
//            fun = FunTest;

//            fun();//使用委托变量调用函数

//            fun += FunTest;
//            fun += FunTest2;
//            fun += FunTest3;
//            fun();


//            btnCLick += Move;
//            btnCLick += Rotate;
//            btnCLick += Scale;
//            //鼠标点击
//            OnButtonClicked();
//            btnCLick -= Rotate;

//            btnCLick = Scale;//赋值 覆盖操作 之前绑定的所有函数 全部覆盖 不安全
//            OnButtonClicked();

//            //*********************************
//            Boss.dead += Move;
//            Boss.dead2 += Move;//事件不允许在类外 使用 = 运算符

//            Boss.dead();//触发绑定函数
//            //Boss.dead2();//事件只能在 定义的源头类 触发  确定了源头 更加安全
//            new Boss().BossDead();





//        }

//    }
//}
