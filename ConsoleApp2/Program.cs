using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp2
{
    public class Program
    {



        static void Main(string[] args)
        {
            #region ArrayList Code

            //ArrayList aList = new ArrayList();
            //aList.Add("Bob");
            //aList.Add(040);

            //Console.WriteLine("Count:{0}", aList.Count);
            //Console.WriteLine("Capacity: {0}", aList.Capacity);

            //ArrayList aList2 = new ArrayList();

            //aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            //aList.AddRange(aList2);

            //Console.WriteLine("Count:{0}", aList.Count);
            //Console.WriteLine("Capacity: {0}", aList.Capacity);

            //aList2.Sort();
            //aList2.Reverse();

            //aList2.Insert(1, "Turkey");

            ////aList.RemoveAt(0);

            ////aList2.RemoveRange(0, 2);

            //Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));



            //foreach(object o in aList)
            //{
            //    Console.Write(o + "\n");

            //}

            //string[] myArray = (string[])aList.ToArray(typeof(string));

            //string[] customers = { "Bob", "sally", "Sue" };

            //ArrayList custArrayList = new ArrayList();

            //custArrayList.AddRange(customers);
            #endregion

            #region dictionary

            //Dictionary<string, string> superheroes = new Dictionary<string, string>();

            //superheroes.Add("Clark Kent", "Superman");
            //superheroes.Add("Bruce Wayne", "Batman");
            //superheroes.Add("Barry West-Allen", "The flash");
            //superheroes.Add("Cara Denver", "Supergirl");
            //Console.WriteLine("Count:{0}", superheroes.Count);

            //superheroes.Remove("Barry West-Allen");
            //Console.WriteLine("Count:{0}", superheroes.Count);

            //Console.WriteLine("Clark Kent : {0}", superheroes.ContainsKey("Clark Kent"));

            //superheroes.TryGetValue("Clark Kent", out string test);

            //Console.WriteLine($"Clark Kent: {test}");

            //foreach(KeyValuePair<string,string> item in superheroes)
            //{
            //    Console.WriteLine("{0} :{1}", item.Key, item.Value);
            //}

            //superheroes.Clear();
            #endregion

            #region Queue
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine("1 in Queue: {0}", queue.Contains(1));

            //Console.WriteLine("Remove :{0}", queue.Dequeue());
            //Console.WriteLine("Peek 1 : {0}", queue.Peek());

            //object[] numArray = queue.ToArray();

            //Console.WriteLine(String.Join(",", numArray));

            //foreach(object o in queue)
            //{
            //    Console.WriteLine($"Queue: {o}");
            //}
            //queue.Clear();
            #endregion


            #region Stack

            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine("Peek 1: {0}", stack.Peek());

            //Console.WriteLine("Pop 1: {0}", stack.Pop());

            //Console.WriteLine("Contains 1: {0}", stack.Contains(2));


            //object[] numbArray = stack.ToArray();

            //Console.WriteLine(String.Join(",", numbArray));

            //foreach(object o in stack)
            //{
            //    Console.WriteLine(o);
            //}

            #endregion

            #region Generics

            List<Animal> animalList = new List<Animal>();

            List<int> numList = new List<int>();

            numList.Add(24);

            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });
            animalList.Insert(1, new Animal() { Name = "Steve" });
            animalList.RemoveAt(1);
            Console.WriteLine("Num of Animals: {0}",
                animalList.Count
                );

            foreach(Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            int x = 5, y = 4;

            Animal.GetSum<int>(ref x, ref y);
            string strX = "5", strY = "4";
            Animal.GetSum<string>(ref strX, ref strY);

            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());
            #endregion
        }

        public struct Rectangle<T>
        {
            private T Width;
            private T Length;

            public T width
            {
                get { return width; }
                set { Width = value; }
            }
            public T length
            {
                get { return length; }
                set { Length = value; }
            }

            public Rectangle(T w,T l)
            {
                Width = w;
                Length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);

                return string.Format($"{Width} * {dblLength}= {dblWidth * dblLength}");
            }
        }
    }
}
