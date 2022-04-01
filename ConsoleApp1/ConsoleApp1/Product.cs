using System;

namespace ArrayConstructor
{
    class Product
    {
        public int No;
        public string Name;
        public double Price;
        private int Count { get; set; }
        public static int _count = 0;

        public Product()
        {


            Console.WriteLine("No daxil et");
            No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name daxil et");
            Name = Console.ReadLine();
            Console.WriteLine("Price daxil et");
            Price = Convert.ToDouble(Console.ReadLine());
            Count = _count++;





        }



    }
}
