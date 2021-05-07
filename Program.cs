using System;

namespace StackNQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Stack A nd Queue Program");
            //Stack stack = new Stack(); //create object of Stack class
            //stack.Push(56); //call Push method Push element in stack 
            //stack.Push(30);//call Push method Push element in stack  
            //stack.Push(70);// call Push method Push element in stack 
            //stack.Display();//call Display method Display element in stack 
            
            ////UC2
            //stack.Peek(); //call Peek method print top of stack 
            //stack.Pop(); //call Pop method and remove top of the stack 
            //stack.isEmpty(); //call isEmpty method remove all elements in stack
            //UC3
            Queue queue = new Queue();  //create object of Queue class
            queue.Enqueue(56); //call method add Element in queue //UC3
            queue.Enqueue(30); //call method add Element in queue //UC3
            queue.Enqueue(70); //call method add Element in queue //UC3
            queue.Display(); //call Display method Display element in Queue  
            queue.Peek(); //call Display method Display Top of the element in Queue 

            queue.Dequeue(); //call Dequeue method //UC4
            queue.IsEmpty(); //call IsEmpty method //UC4

            Console.ReadLine();



        }
    }
}
