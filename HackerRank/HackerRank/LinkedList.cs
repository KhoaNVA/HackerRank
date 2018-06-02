using System;

namespace HackerRank
{
    class MyLinkedList<T>
    {
        public MyLinkedList(T data)
        {
            Data = data;
        }

        public T Data { get; set; }

        public MyLinkedList<T> Next { get; set; }
    }

    class TestLinkedList
    {
        public static void Run()
        {
            MyLinkedList<int> head = new MyLinkedList<int>(1);
            MyLinkedList<int> first = new MyLinkedList<int>(2);
            MyLinkedList<int> second = new MyLinkedList<int>(3);
            MyLinkedList<int> third = new MyLinkedList<int>(4);

            head.Next = first;
            first.Next = second;
            second.Next = third;

            Display(head);
            var newHead = Reverse(head);
            Display(newHead);
            Console.ReadLine();
        }

        private static MyLinkedList<int> Reverse(MyLinkedList<int> head)
        {
            Console.WriteLine("reversing...");

            MyLinkedList<int> prev = null;
            MyLinkedList<int> curr = null;
            MyLinkedList<int> next = null;
            if (head.Next != null)
            {
                prev = head;
                curr = prev.Next;
                while (head.Next != null)
                {
                    if (curr.Next != null)
                    {
                        next = curr.Next;
                        curr.Next = prev;
                        prev = curr;
                        curr = next;
                    }
                    else
                    {
                        curr.Next = prev;
                        head.Next = null;
                        return curr;
                    }
                }
            }            
            return head;
        }

        private static void Display(MyLinkedList<int> head)
        {
            Console.WriteLine(head.Data);
            while (head.Next != null)
            {
                head = head.Next;
                Console.WriteLine(head.Data);
            }
        }
    }
}
