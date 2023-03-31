using System;
namespace day14_StackAndQueuesProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue Program!");
            Console.WriteLine("#####################");

            StackWithLinkedList obj = new StackWithLinkedList();
            obj.push(70);
            obj.push(30);
            obj.push(56);
            obj.Display();
        }

    }
}

