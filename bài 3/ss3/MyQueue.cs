using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss3
{
    internal class MyQueue
    {
        Node2 rear, front;
        public bool IsEmpty()
        {
            return rear == null || front == null;
        }
        public void Enqueue(object ele)
        {
            Node2 n = new Node2();
            n.data = ele;
            if (rear == null)
            {
                rear = n;
                front = n;
            }
            else
            {
                rear.prev = n;
                n.next = front;
                rear = n;
            }
        }
        public Node2 Dequeue()
        {
            if (front == null) return null;
            Node2 d = front;
            front = front.prev;
            if (front == null) rear = null;
            else
                front.next = null;
            return d;
        }
    }
}
