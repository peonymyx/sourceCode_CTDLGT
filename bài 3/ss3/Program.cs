using ss3;

/*Mystack ms = new Mystack();
Console.WriteLine(ms.IsEmpty());
ms.Push(1);
ms.Push(2);
ms.Push(3); 
Console.WriteLine(ms.IsEmpty());
Console.WriteLine(ms.Peek());
Node n = ms.Pop();

Console.WriteLine(n == null ? "null" : n.data);
n = ms.Pop();
Console.WriteLine(n == null ? "null" : n.data);
n = ms.Pop();
Console.WriteLine(n == null ? "null" : n.data); 
n = ms.Pop();
Console.WriteLine(n == null ? "null" : n.data);
Console.WriteLine(ms.IsEmpty());
*/

MyQueue mq = new MyQueue();
Console.WriteLine(mq.IsEmpty());
mq.Enqueue(1);
mq.Enqueue(2);
mq.Enqueue(3);
Console.WriteLine(mq.IsEmpty());
Node2 n = mq.Dequeue();
Console.WriteLine(n == null ? "null" : n.data);
n = mq.Dequeue();
Console.WriteLine(n == null ? "null" : n.data);
n = mq.Dequeue();
Console.WriteLine(n == null ? "null" : n.data);
n = mq.Dequeue();
Console.WriteLine(n == null ? "null" : n.data);
Console.WriteLine(mq.IsEmpty());