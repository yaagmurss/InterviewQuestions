using System;
using System.Collections;

namespace DataStructureAndAlgorithms
{
    class StacksClass
    {
        public void SampleStacks()
        {

            //Last in first out (LIFO) (non-generic collection of objects.)

            //It uses the following operations: 
            //• pop(): Remove the top item from the stack.
            //• push(item) : Add an item to the top of the stack.
            //• peek ( ): Return the top of the stack. 
            //• is£mpty() : Return true if and only if the stack is empty.
            // Creates and initializes a new Stack.

            // Creates a new Stack.
            Stack myStack = new Stack();

            // Push Elements
            myStack.Push("Yagmur");
            myStack.Push("Solmaz");
            myStack.Push("Burak");
            myStack.Push("Fil");

            // Displays the properties and values of the Stack.
            Console.WriteLine("Stack's name is : {0}", "myStack");
            Console.WriteLine("Stack's element count : {0}", myStack.Count);
            Console.Write("Values : ");
            foreach (Object obj in myStack) { Console.Write(" {0} ", obj); }

            // Peek Element
            Console.WriteLine("\nPeek Of The Stack :{0} ", myStack.Peek());

            // Pops Elements
            myStack.Pop();            
            Console.Write("Values After using Pop : ");
            foreach (Object obj in myStack) { Console.Write(" {0} ", obj); }


        }

        
}
}
