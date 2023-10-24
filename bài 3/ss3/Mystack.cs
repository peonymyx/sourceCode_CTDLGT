using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss3
{
    internal class Mystack
    {
        Node top;
        public bool IsEmpty() { return top == null; }

        public void Push(object ele)
        {
            Node n = new Node();
            n.data = ele;
            n.next = top;
            top = n;
        }
        public Node Pop() 
            { 
            if (top == null)
            {
                return null;
            }
            Node d = top;
            top = top.next;
            return d;
        }
        public object Peek()
        {
            if(IsEmpty()) { return null; }
            Node d = top;
            return d.data;
        }
        
    }
}
