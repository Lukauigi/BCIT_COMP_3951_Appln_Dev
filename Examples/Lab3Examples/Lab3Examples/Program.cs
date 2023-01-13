using System;

namespace Lab3Examples
{
    
    class Program
    {
        /*
        public abstract class Book
        {
            protected string title;
            protected string author;
            protected string publisher;

            // base class constructor with 3 paramaters. Why do we need the public keyword?
            public Book(string title, string author, string publisher)
            {
                this.author = author;
                this.title = title;
                this.publisher = publisher;
            }
        }

        // Represents a book that has lost its identifying info and most supplementary info
        public class RuinedBook : Book
        {
            // No present paramterless constructor tries to invoke base class'
            // parameterless constructor, but there is none.
            // creates a compile-time error.
            public void DoSomething()
            {
                Console.WriteLine("did something");
            }
        }      

        */

        /* How can we avoid the compile-time error? How can we construct a child with no defined constructor? */

        
        
        // base class of class Novel
        public abstract class Book
        {
            protected string title;
            protected string author;
            protected string publisher;

            // base class constructor with 3 paramaters
            public Book(string title, string author, string publisher)
            {
                this.author = author;
                this.title = title;
                this.publisher = publisher;
            }

            // add a default constructor to use
            public Book()
            {
                this.title = null;
                this.author = null;
                this.publisher = null;
            }
        }

        // Represents a book that has lost its identifying info and most supplementary info
        public class RuinedBook : Book
        {
            public void DoSomething()
            {
                Console.WriteLine("did something");
            }
        }
        static void Main(string[] args)
        {
            RuinedBook destroyedBook = new RuinedBook();
            destroyedBook.DoSomething();
        }
    }
}

