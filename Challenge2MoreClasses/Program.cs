using System;

namespace Challenge2MoreClasses
{
    class Keyboards
    {
        public string brand = "Black Web";
        public void type()
        {
            Console.WriteLine("Click Clack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Keyboards myKeyboard = new Keyboards();
            myKeyboard.type();
            Console.WriteLine(myKeyboard.brand + " Keyboards are good");
        }
    }
}
