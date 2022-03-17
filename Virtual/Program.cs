using System;

namespace Virtual
{
    class Program
    {
        class Object
        {
            public virtual void Method()
            {
                Console.WriteLine("Object");
            }
        }
        class Child : Object
        { 
            public override void Method()
            {
                Console.WriteLine("Child");
            }
        }
        static void Main(string[] args)
        {
            Object obj1 = new Child();
            obj1.Method();

            Object obj2 = new Object();
            obj2.Method();

            Child obj3 = new Child();
            obj3.Method();
        }
    }
}