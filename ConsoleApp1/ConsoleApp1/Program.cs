using System;

namespace ArrayConstructor
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ne qeder kitab daxil etmek isteyirsiniz");
            int BookNum = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[BookNum];



            for (int i = 0; i < BookNum; i++)
            {
                Console.WriteLine($"kitab:{i + 1}");
                books[i] = new Book();
            }



            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine("1.kitablari qiymete gore filterle/n 2.butun kitablari goster/n 0.proqrami bagla");
                int input = Convert.ToInt32(Console.ReadLine());
                i = input - 1;
                switch (input)
                {
                    case 1:
                        Console.WriteLine("axtaris etmek istediyiniz minimum qiymeti daxil edin");
                        int MinValue = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("axtaris etmek istediyiniz maximum qiymeti daxil edin");
                        int MaxValue = Convert.ToInt32(Console.ReadLine());
                        foreach (Book book in books)
                        {
                            if (book.Price >= MinValue && book.Price <= MaxValue)
                            {
                                Console.WriteLine($"No:{book.No} Name:{book.Name} Price:{book.Price} Genre:{book.Genre}");
                            }
                        }
                        break;
                    case 2:
                        foreach (Book book in books)
                        {

                            Console.WriteLine($"No:{book.No} Name:{book.Name} Price:{book.Price} Genre:{book.Genre}");

                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("unknown value");
                        break;

                }

            }

        }
    }
}
