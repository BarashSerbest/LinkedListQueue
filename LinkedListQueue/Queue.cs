using System;

namespace LinkedListQueue
{
    
class Node
    {
        public int Data;
        public Node Next;
    }
class Queue
    {
        private Node front;
        private Node rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int data) // Geriye değer döndürmeyecek şekilde "void" tanımlandı.
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }

            Console.WriteLine($"Girdiğiniz {data} elemanı kuyruğa eklendi.");
        }

        public void Dequeue() // Geriye değer döndürmeyecek şekilde "void" tanımlandı.
        {
            if (front == null)
            {
                Console.WriteLine("Kuyruk boş. Eleman çıkarılamaz.");
                return;
            }

            int removedData = front.Data;
            front = front.Next;

            if (front == null)
                rear = null;

            Console.Write($"\nÇıkarılan eleman: {removedData}");
        }

        public void PrintQueue() // Geriye değer döndürmeyecek şekilde "void" tanımlandı.
        {
            if (front == null)
            {
                Console.WriteLine("Kuyruk boş.");
                return;
            }

            Console.Write("\nKuyruk elemanları: ");
            Node current = front;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}
