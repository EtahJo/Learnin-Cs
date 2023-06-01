using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp2
{

    delegate double doubleIt(double val);

    public class Program
    {



        static void Main(string[] args)
        {
            #region Lambda

            //doubleIt dblIT = x => x * 2;

            //Console.WriteLine($"5 * 2 = {dblIT(5)}");


            #endregion
            #region Where

            //List<int> numList = new List<int> { 1, 9, 2, 6, 3 };

            //var evenList = numList.Where(a => a % 2 == 0).ToList();

            ////foreach (var j in evenList)
            ////    Console.WriteLine(j);




            // var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();

            //foreach (var j in rangeList)
            //    Console.WriteLine(j);


            //List<int> flipList = new List<int>();

            //int i = 0;
            //Random rnd = new Random();

            //while (i < 100)
            //{
            //    flipList.Add(rnd.Next(1, 3));
            //    i++;
            //}

            //Console.WriteLine("Heads: {0}",
            //flipList.Where(a => a == 1).ToList().Count());


            //Console.WriteLine("Tails: {0}",
            //flipList.Where(a => a == 2).ToList().Count());

            //var nameList = new List<string> { "Doug", "Sally", "Sue" };

            //var sNames = nameList.Where(x => x.StartsWith("S"));

            //foreach (var j in sNames)
            //    Console.WriteLine(j);


            #endregion

            #region Select

            //var OneTo10 = new List<int>();
            //OneTo10.AddRange(Enumerable.Range(1, 10));

            //var squares = OneTo10.Select(x => x * x);
            // foreach(var j in squares)
            //{
            //    Console.WriteLine(j);
            //}

            #endregion

            #region Zip, aggregrate, average,all,any,distinct,except,intersect

            var numList2 = new List<int>() { 1,2,3,3,4,7,7,4,5};
            //var listTwo = new List<int>(new int[] { 4, 5, 6 });

            //var sumList = listOne.Zip(listTwo,(x,y)=>x+y).ToList();

            //foreach(var i in sumList)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine("Sum {0}",

                numList2.Aggregate((a, b) => a + b));


            Console.WriteLine("Average {0}",

             numList2.AsQueryable().Average());


            Console.WriteLine("All > 3:{0}",

            numList2.All(x=>x>3));


            Console.WriteLine("Any Items >3: {0}",

            numList2.Any(x=>x>3));

            Console.WriteLine("Distint :{0}",
                string.Join(", ", numList2.Distinct()));


            #endregion

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

            //List<Animal> animalList = new List<Animal>();

            //List<int> numList = new List<int>();

            //numList.Add(24);

            //animalList.Add(new Animal() { Name = "Doug" });
            //animalList.Add(new Animal() { Name = "Paul" });
            //animalList.Add(new Animal() { Name = "Sally" });
            //animalList.Insert(1, new Animal() { Name = "Steve" });
            //animalList.RemoveAt(1);
            //Console.WriteLine("Num of Animals: {0}",
            //    animalList.Count
            //    );

            //foreach(Animal a in animalList)
            //{
            //    Console.WriteLine(a.Name);
            //}

            //int x = 5, y = 4;

            //Animal.GetSum<int>(ref x, ref y);
            //string strX = "5", strY = "4";
            //Animal.GetSum<string>(ref strX, ref strY);

            //Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            //Console.WriteLine(rec1.GetArea());

            //Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            //Console.WriteLine(rec2.GetArea());
            #endregion

            #region delegates

            //Arithmetic add, sub, addSub;
            //add = new Arithmetic(Add);
            //sub = new Arithmetic(Substract);

            //addSub = add + sub;

            //Console.WriteLine($"Add {6} & {10}");
            //add(6, 10);
            //Console.WriteLine($"Add & Substract {10} & {4}");

            //addSub(10, 4);

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

        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1 , double num2)
        {
            Console.WriteLine($"{num1}+ {num2} = {num1 + num2}");

        }
        public static void Substract(double num1, double num2)
        {
            Console.WriteLine($"{num1}-{num2} = {num1 - num2}");

        }
    }
}
