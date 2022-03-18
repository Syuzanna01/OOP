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

            //public void Method()
            //{
            //    Console.WriteLine("Child");
            //}
        }
        static void Main(string[] args)
        {
            Object obj1 = new Child();
            obj1.Method();//Child

            Object obj2 = new Object();
            obj2.Method();//Object

            Child obj3 = new Child();
            obj3.Method();//Child


            //Object obj1 = new Child();
            //obj1.Method();//Object

            //Object obj2 = new Object();
            //obj2.Method();//Object

            //Child obj3 = new Child();
            //obj3.Method();//Child
        }
    }
}