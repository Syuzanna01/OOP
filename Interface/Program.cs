using System;

namespace Inheritance
{
    class Program
    {
        interface IDog
        {
            string Animall { get; set; }
            string Name { get; set; }
            string Voice { get; set; }
            public void Method()
            {
                Console.WriteLine(Animall);
                Console.WriteLine("Name " + Name);
                Console.WriteLine("Voice " + Voice);
            }
        }
        interface ICat
        {
            string Animall { get; set; }
            string Name { get; set; } 
            string Voice { get; set; }
            public void Method() 
            {
                Console.WriteLine(Animall);
                Console.WriteLine("Name " + Name);
                Console.WriteLine("Voice " + Voice);
            }
        } 
        interface IOz
        {
            string Animall { get; set; }
            string Name { get; set; }
            string Voice { get; set; }
            public void Method()
            {
                Console.WriteLine(Animall);
                Console.WriteLine("Name " + Name);
                Console.WriteLine("Voice " + Voice);
            }
        }
        class Animal : IDog, ICat, IOz
        {
            public string Name { get; set; }
            public string Voice { get; set; }
            public string Animall { get; set; }
        }
        static void Main(string[] args)
        {
            IDog dog = new Animal();
            dog.Animall = "Shun";
            dog.Name = "Jeko";
            dog.Voice = "Haf";
            dog.Method();

            Console.WriteLine();

            ICat cat = new Animal();
            cat.Animall = "Katu";
            cat.Name = "Lusi";
            cat.Voice = "Miau";
            cat.Method();

            Console.WriteLine();

            IOz oz = new Animal();
            oz.Animall = "Oz";
            oz.Name = "Anakonda";
            oz.Voice = "ssssss";
            oz.Method();
        }
    }
}