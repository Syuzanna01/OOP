using System;

namespace Arrayy
{
    class Resource
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public dynamic Xumb { get; set; }
        public string Bajin { get; set; }

        public Resource(string Name ,string Surname,int Age, dynamic Xumb,string Fakultet)
        {
            this.Name = Name; this.Surname = Surname; this.Age = Age; this.Xumb = Xumb; this.Bajin = Fakultet; 
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Resource resource = new Resource("Aram","Xazaryan",100,"TT919-2","Cr.Char");
        }
    }
}