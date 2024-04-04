
using System;
using System.Collections;//非泛型集合命名空间
using System.Collections.Generic;//泛型集合命名空间
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.集合类
{
    /*
     泛型集合：泛型容器用于存储数据 的一种数据结构
        List<T>数组    LinkList<T>链表   Dictionary<T,T>（字典）关系类型容器
          命名空间：using System.Collections.Generic;
     @@推荐使用  不存储拆装箱操作 统一存储类型更加安全


     非泛型集合 ：不推荐使用 在泛型编程产生之前的使用的集合 
      原理 保存Object类型数据 特点 可以存储任意类型的数据
      例如：ArrayList，HashTable...
      命名空间： using System.Collections
     ###非泛型集合 可存储任意类型 在使用时 会进行大量拆装箱操作 实际开发不推荐使用

         */
    class Main3
    {
        static void Main()
        {
            //非泛型集合****************不推荐使用
            ArrayList array = new ArrayList();
            array.Add("张飞");
            array.Add(250);
            array.Add(3.25f);
            array.Add('A');
            //var ------ auto  自动类型关键字
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


            //**************************泛型集合使用测试
            List<string> li = new List<string>();//数组
            //添加
            li.Add("古力娜扎");
            li.Add("马尔扎哈");
            string[] str = { "赵云" ,"马超" ,"马云禄" ,"张辽"};
            li.AddRange(str);

            //查询
            foreach (var name in li)
            {
                Console.WriteLine(name);
            }
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }

            //修改
            li[0] = "米力扎哈";
            Console.WriteLine(li[0]);

            //删除
            li.Remove("米力扎哈");//删除指定元素
            li.RemoveAt(2);//删除指定下标的元素
            //li.Clear();//删除全部

            //////////////////链表
            LinkedList<string> link = new LinkedList<string>();
            //添加
            link.AddLast("张飞");//尾部
            link.AddFirst("赵云");//头部添加

            //查找
            LinkedListNode<string> node = link.Find("张飞");
            //node.Next;//下一个节点
            //node.Previous;//上一个节点

            link.AddBefore(node, "刘备");//在指定节点前加入元素
            link.AddAfter(node, "曹操");

            foreach (var item in link)
            {
                Console.WriteLine(item);
            }
            //删除
            link.RemoveFirst();
            link.RemoveLast();
            //link.Clear();


            //********************************字典
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //添加键值对
            dic.Add(10052, "张郃");
            dic.Add(10032, "张角");
            dic.Add(10096, "张辽");

            //查找  & 修改
            dic[10052] = "张宝";

            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in dic.Values)
            {
                Console.WriteLine(value);
            }
            foreach (KeyValuePair<int,string> pair in dic)//遍历键值对
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }

            //判断键是否存在
            if(dic.ContainsKey(10052))
            {
                Console.WriteLine("存在10052 -->" + dic[10052]);
            }




        }

    }
}
