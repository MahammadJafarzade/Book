using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConstructor
{
    class Book : Product
    {
        public string Genre;
        public Book() : base()
        {
            Console.WriteLine("genre daxil et");
            Genre = Console.ReadLine();
        }
    }
}
