using System;

namespace Arrayy
{
    class Program
    {
        class MyClass
        {
            private dynamic[] array;
            public MyClass(dynamic[] array)
            {
                this.array = array;
            }
            public void Method()
            {
                array[1] = 8;
            }
            public void Add()
            {
                dynamic[] add = new dynamic[array.Length + 1];
                for (int i = 0; i < add.Length - 1; i++)
                    add[i] = array[i];

                add[3] = "gd";
            }
            public void Delete()
            {
                Array.Clear(array, 1, 1);
            }
            public void Lenght() 
            {
                int Len = array.GetLength(0);
            }
        }
        static void Main() 
        {
            dynamic[] array = { 2, "jh", 'h', 85 };
            MyClass myClass = new MyClass(array);
            myClass.Method();
            myClass.Add();
            myClass.Delete();
            myClass.Lenght();
        }
    }
}