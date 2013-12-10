using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    public class CollectionExamples
    {
        private static void DisplayEnumerator<T>(IEnumerable<T> e)
        {
            foreach (T element in e)
            {
                if (!element.Equals(e.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
        }

        private static void DisplayList<T>(List<T> list)
        {
            foreach (T element in list)
            {
                if (!element.Equals(list.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
            /*
            for (int i = 0; i<list.Count; i++)
            {
                if (!list[i].Equals(list.Last()))
                {
                    Console.Write(list[i] + ",");
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
           }*/
        }

        private static void DisplayLinkedList<T>(LinkedList<T> list)
        {
            foreach (T element in list)
            {
                if (!element.Equals(list.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
        }

        private static void DisplayQueue<T>(Queue<T> q)
        {
            foreach (T element in q)
            {
                if (!element.Equals(q.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
        }

        private static void DisplayStack<T>(Stack<T> stack)
        {
            foreach (T element in stack)
            {
                if (!element.Equals(stack.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
        }

        private static void DisplayDictionary<TK,TV>(Dictionary<TK,TV> dict)
        {
            foreach (KeyValuePair<TK,TV> element in dict)
            {
                if (!element.Equals(dict.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
        }

        private static void DisplayHashSet<T>(HashSet<T> hs)
        {
            foreach (T element in hs)
            {
                if (!element.Equals(hs.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
        }

        private static void DisplaySortedSet<T>(SortedSet<T> hs)
        {
            foreach (T element in hs)
            {
                if (!element.Equals(hs.Last()))
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
        }

        // Explicit predicate delegate. 
        private static bool FindName(string sName)
        {

            if (sName == "Keir")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static void ListCollectionFunc()
        {
            List<int> lNumbers = new List<int> { 1, 3, 2 };

            lNumbers.Add(5);
            lNumbers.Add(4);

            lNumbers.Sort();

            DisplayList<int>(lNumbers);


            List<string> lNames = new List<string> { "Ken", "Amanda", "Emily" };

            lNames.Add("Keir");

            lNames.Sort();

            DisplayList<string>(lNames);

            int nSearch = lNames.FindIndex(
                delegate(string sName)
                {
                    return sName.CompareTo("Ken") == 0;
                }
                );

            int nSearchAgain = lNames.FindIndex(FindName);
        }

        public static void LinkedListCollectionFunc()
        {
            LinkedList<int> LList = new LinkedList<int>();
            LinkedListNode<int> Element= LList.AddFirst(1);
            LList.AddLast(5);
            Element = LList.AddAfter(Element, 2);
            Element = LList.AddAfter(Element, 3);
            Element= Element.Next;
            Element = LList.AddBefore(Element, 4);

            DisplayLinkedList<int>(LList);
        }

        public static void QueueCollectionFunc()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            Queue<int> q= new Queue<int>(array1);

            q.Enqueue(6);

            DisplayQueue<int>(q);

            Stack<int> stack = new Stack<int>(array1);
            stack.Push(6);
            int nTop= stack.Pop();

            DisplayStack<int>(stack);
        }

        public static void DictionaryCollectionFunc()
        {
            Dictionary<string, int> UserPIN = new Dictionary<string, int>();
            UserPIN.Add("Ken", 9001);
            UserPIN.Add("Amanda", 5001);
            UserPIN.Add("Emily", 3001);
            UserPIN.Add("Keir", 1001);

            KeyValuePair<string, int> KVP= new KeyValuePair<string,int>("Ken", 9001);
            if (UserPIN.Contains(KVP))
            {
                UserPIN.Remove("Emily");
                KVP = UserPIN.Last();
            }
            DisplayDictionary(UserPIN);

            Dictionary<string, int>.KeyCollection Keys = UserPIN.Keys;
            Dictionary<string, int>.ValueCollection Values = UserPIN.Values;

            List<string> sKeys= new List<string>(Keys.ToList<string>());
            DisplayList<string>(sKeys);
            DisplayList<int>(Values.ToList<int>());
        }

        public static void HashSetCollectionFunc()
        {
            List<string> lNames = new List<string> { "Ken", "Amanda", "Emily", "Keir" };

            HashSet<string> hs = new HashSet<string>(lNames);

            hs.Add("Amanda");
            hs.Add("Jonny");

            DisplayHashSet(hs);

            SortedSet<string> ss = new SortedSet<string>(lNames);

            ss.Add("Amanda");
            ss.Add("Jonny");

            DisplaySortedSet(ss);

            SortedSet<string> ss2 = new SortedSet<string>(lNames);
            IEnumerable<string> result= ss2.Intersect(ss);
            DisplayEnumerator<string>(result);
        }


        public static void CollectionFunc()
        {
            ListCollectionFunc();
            LinkedListCollectionFunc();
            QueueCollectionFunc();
            DictionaryCollectionFunc();
            HashSetCollectionFunc();
        }
    }
}