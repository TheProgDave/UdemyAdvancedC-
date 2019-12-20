using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

// Language Integrated Query
namespace LINQ
{
    
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>() 
            { 
                new Book() { Title = "ADO.Net Step by Step", Price = 5},
                new Book() { Title = "ASP.Net MVC", Price = 9.99f},
                new Book() { Title = "ASP.Net MVC Web API", Price = 12},
                new Book() { Title = "C# Advanced Topics", Price = 9},

            };
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {


            var library = new BookRepository().GetBooks();
            // With LINQ Query Operators
            var cheaperBooks = 
                from book in library 
                where book.Price < 10 
                orderby book.Title 
                select book.Title;




            // With LINQ extension methods
            var cheapBooks = library
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            Nullable<DateTime> date = null;
            DateTime? dateAgain = null;




            foreach (var title in cheapBooks)
            {
                Console.WriteLine(title);
            }

        }
    }
}
