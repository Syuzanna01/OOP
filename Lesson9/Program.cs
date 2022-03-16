using System;


namespace _2_Inheritance
{
    class Program
    {
        class Car
        {
            public string Brand;
            public string Color;
            internal int aa;
        }
        class BMW : Car
        {
            protected int price4 = 80000;
            protected int priceX6 = 120000;
            public string fueltime;
        }
        class Series4 : BMW
        {
            protected string Name = "Series4";
            
            public Series4()
            {
                Console.WriteLine(Name);
                Console.WriteLine(price4);
            }
            public void Benzik()
            {
                fueltime = "benzin";
                Color = "Blue";
                Console.WriteLine(fueltime);
                Console.WriteLine(Color);
            }
        }
        class SeriesX6 : BMW
        {
            protected string Name = "SeriesX6";
            public SeriesX6()
            {
                Console.WriteLine(Name);
                Console.WriteLine(priceX6);
            }
            public void Dizel()
            {
                fueltime = "dizel";
                Color = "Red";
                Console.WriteLine(fueltime);
                Console.WriteLine(Color);
            }
        }
        static void Main(string[] args)
        {
            Series4 series = new Series4();
            series.Benzik();

            Console.WriteLine();

            SeriesX6 seriesX6 = new SeriesX6();
            seriesX6.Dizel();
        }
    }
}