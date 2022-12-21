using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Genaric
    {
        public static void Test1()//list
        {
            List<int> obj = new List<int>();
            obj.Add(12);
            obj.Add(14);
            obj.Add(24);
            foreach (int i in obj)
            {
                Console.WriteLine("values:" + i);
            }
            List<string> obj2 = new List<string>();
            obj2.Add("pavan");
            obj2.Add("kumar");
            obj2.Add("puppala");



            foreach (var j in obj2)
            {
                Console.WriteLine("name:" + j);
            }

        }
        public static void Test2()//hashset
        {
            HashSet<int> obj3 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
            HashSet<string> obj4 = new HashSet<string> { "pavan", "srinu" };
            foreach (var k in obj3)
            {
                Console.WriteLine(k);
            }
            foreach (var p in obj4)
            {
                Console.WriteLine(p);
            }
        }
        public static void Test3()//sortedset
        {
            SortedSet<int> obj5 = new SortedSet<int> { 1, 2, 3, 4, 5, 6 };
            SortedSet<string> obj6 = new SortedSet<string> { "ramu", "ashok" };
            foreach (var l in obj5)
            {
                Console.WriteLine(l);
            }
            foreach (var m in obj6)
            {
                Console.WriteLine(m);
            }
        }
        public static void Test4()//stack
        {
            Stack<int> obj7 = new Stack<int>();
            obj7.Push(1);
            obj7.Push(2);
            obj7.Push(9);
            obj7.Push(7);
            obj7.Push(0);


            foreach (int n in obj7)
            {
                Console.WriteLine(n);
            }

        }

        public static void Test5()//queue
        {
            Queue<int> obj8 = new Queue<int>();
            obj8.Enqueue(8);
            obj8.Enqueue(2);
            obj8.Enqueue(6);
            obj8.Enqueue(7);
            obj8.Enqueue(0);
            foreach (int o in obj8)
            {
                Console.WriteLine(o);
            }


        }
        public static void Test6()//linkedlist
        {
            LinkedList<string> obj9 = new LinkedList<string>();
            obj9.AddFirst("pavan");
            obj9.AddFirst("man");
            obj9.AddFirst("unnn");
            obj9.AddFirst("kumar");
            obj9.AddFirst("happy");
            foreach (string q in obj9)
            {
                Console.WriteLine(q);
            }
            LinkedListNode<String> node = obj9.Find("Pavan");


        }
        public static void Test7()//dictionary
        {
            Dictionary<string, string> obj10 = new Dictionary<string, string>();
            obj10.Add("1", "happy");
            obj10.Add("2", "days");
            obj10.Add("3", "to ");
            obj10.Add("4", "life");
            foreach (KeyValuePair<string, string> kv in obj10)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }



        }
        public static void Test8() //sorteddictionary
        {

            SortedDictionary<string, string> obj10 = new SortedDictionary<string, string>();
            obj10.Add("1", "happy");
            obj10.Add("2", "days");
            obj10.Add("4", "to ");
            obj10.Add("3", "life");
            foreach (KeyValuePair<string, string> kv in obj10)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }


        public static void Test9() //sortedlist
        {

            SortedList<string, string> obj11 = new SortedList<string, string>();
            obj11.Add("1", "happy");
            obj11.Add("4", "days");
            obj11.Add("2", "to ");
            obj11.Add("3", "life");
            foreach (KeyValuePair<string, string> kv in obj11)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }




    }


    
}
