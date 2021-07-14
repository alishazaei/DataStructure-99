using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QUEUE<int> q = new QUEUE<int>(4);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(8);
            q.Enqueue(9);
            q.Enqueue(10);
            q.Display();


        }
    }


    class QUEUE<T>
    {

        private int rear;
        private int front;
        private int max;
        T[] queue; 
        public QUEUE(int size)
        {

            max = size;
            rear = -1;
            front = -1;
            queue = new T[max];
        }

        public void Enqueue (T input)
        {

            if ( (rear + 1) % max == front || (front == -1 && rear == max-1))
            {
                Console.WriteLine("Queue is full");
            }
            else
            {

                rear = (rear + 1) % max;
                queue[rear] = input;
                
            }

            
        }

        public void Dequeue()
        {
            if ( rear == front)
            {
                Console.WriteLine("Queue is empty");
            }
            else if ( front == -1 )
            {
                front = (front + 2) % max;
            }
            else
            {
                front = (front + 1) % max;
              
                
            }

     
         

        }

        public void Display ()
        {
            for ( int i = 0; i < queue.Length; i++)
            {
               Console.WriteLine( queue[i]);
            }


        }





    }


}
