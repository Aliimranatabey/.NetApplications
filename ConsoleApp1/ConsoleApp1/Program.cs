using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = false;
            int number1 = 24564654;
            long number2 = 65456454;
            short number3 = 123;
            byte number4 = 0; //0-255 arası
            char karakter = 'A';
            double number5 = 10.4564;
            decimal number6 = 10.4564m;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is " + number1);
            Console.WriteLine("Number2 is " + number2);
            Console.WriteLine("Number3 is " + number3);
            Console.WriteLine("Number4 is " + number4);
            Console.WriteLine("Karakter is " + karakter); // +int(karakter) yazsaydık A harfine karşılık gelen sayıyı bize verirdi
            Console.WriteLine("Number5 is " + number5);
            Console.WriteLine("Number6 is " + number6);
            Console.WriteLine("Number7 is " + number7);
            
            Console.ReadLine();
        }
    }
    enum days
    {
        monday=20,tuesday=65, wednesday, thursday ,friday ,saturday ,sunday
    }
}
