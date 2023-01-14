using System;

namespace ConsoleApp1
{

    class C
    {
        int number = 1020;
        public void F()
        {
            Nested n = new Nested(this);
            n.G();
        }
        public class Nested
        {

            C this_C_Class;

            public Nested(C c)
            {
                this_C_Class = c;
            }
            public void G()
            {
                Console.WriteLine(this_C_Class.number);
            }
        }
    

    static void Main(string[] args)
        {
            // the following code called in another function.
            C c = new C();
            c.F();
        }
    }
}
