using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Node<T> : IComparable<Node<T>> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node(T data)
        {
            Data = data;
        }

        public Node<T> Prev { get; set; } // Cсылка на следующий элемент
        public Node<T> Next { get; set; } // Cсылка на предыдущий элемент

        public int CompareTo(Node<T> other)
        {
            if (other == null) return 1;
            return Data.CompareTo(other.Data);
        }
        public static bool operator >(Node<T> operand1, Node<T> operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }
        public static bool operator <(Node<T> operand1, Node<T> operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }
        public static bool operator >=(Node<T> operand1, Node<T> operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }
        public static bool operator <=(Node<T> operand1, Node<T> operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }
    }
    public class GenericsDescSortedList<T> where T : IComparable<T>
    {


        Node<T> head; // Первый элемент списка
        Node<T> tail; // Конечный элемент списка
        int count;
        public int Count
        {
            get { return count; }
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> current = head;
            Node<T> temp;
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                while (node < current)
                {
                    Console.WriteLine("элемент({0}) следует после элемента({1})", node.Data, current.Data);
                    if (node >= current.Next && current.Next != null)
                    {
                        Console.WriteLine("элемент({0}) следует до элемента({1})", node.Data, current.Next.Data);
                        // добавляем между current и current.Next
                        temp = current.Next;

                        current.Next = node;
                        node.Prev = current;
                        temp.Prev = node;
                        node.Next = temp;

                    }
                    else if (current.Next == null && node <= current)
                    {
                        tail.Next = node;
                        node.Prev = tail;
                        tail = node;
                    }

                    current = current.Next;
                }
                if (head == tail)
                {
                    Console.WriteLine("head == tail");
                    if (node < head)
                    {
                        Console.WriteLine("head == tail: node<head");
                        tail.Next = node;
                        node.Prev = tail;
                        tail = node;
                    }
                    if (node > head)
                    {
                        Console.WriteLine("head == tail: node>head");
                        head.Prev = node;
                        node.Next = head;
                        head = node;
                    }
                }
                if (node > head)
                {
                    Console.WriteLine("node>head");
                    head.Prev = node;
                    node.Next = head;
                    head = node;

                }


            }
            Console.WriteLine("Хвост : {0}", tail.Data);
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;

            node.Next = temp;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Prev = node;
            }
            count++;
        }

        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = tail;

            node.Prev = temp;
            tail = node;
            if (count == 0)
            {
                head = tail;
            }
            else
            {
                temp.Next = node;
            }
            count++;
        }

        public T GetRand()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            int N = count;
            //Получить случайное число (в диапазоне от 0 до 10)
            int rand_node = rnd.Next(0, N);

            Node<T> result = head;

            for (int i = 0; i < rand_node; i++) // Идем к нужному элементу
            {
                result = result.Next;
            }

            return result.Data;
        }

        public T GetN(int N)
        {
            if (N <= count)
            {
                Node<T> result = head;
                for (int i = 1; i < N; i++)
                {
                    result = result.Next;
                }
                return result.Data;
            }
            else throw new IndexOutOfRangeException();
        }

        public T GetMax()
        {
            Node<T> result = head;
            Node<T> current = head;
            int N = count;
            for (int i = 0; i < N; i++)
            {
                if (result < current)
                {
                    result = current;
                }
                current = current.Next;
            }
            return result.Data;
        }
        public T GetMin()
        {
            Node<T> result = tail;
            Node<T> current = tail;
            int N = count;
            for (int i = 0; i < N; i++)
            {
                if (result > current)
                {
                    result = current;
                }
                current = current.Prev;
            }
            return result.Data;
        }

    }
}
