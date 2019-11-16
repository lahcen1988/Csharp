using System;
using System.Collections.Generic;
using LINQ.LINQ1;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<string> Names = new List<string>()
            {
                "lahcen","soukaina","khadija","bab","saida","imane","safae","tat"
            };

            Console.WriteLine("**************  Without LINQ *****************");
            LINQ1.LINQ1.WithoutLinq(Names);

            Console.WriteLine("**************  Without Anonymous method *****************");
            LINQ1.LINQ1.WithAnonymousMethod(Names);

            Console.WriteLine("**************  With LINQ Query Syntax *****************");
            LINQ1.LINQ1.WithLinq_QuerySyntax(Names);

            Console.WriteLine("**************  With LINQ Non Query Syntax *****************");
            LINQ1.LINQ1.WithLinq_NonQuerySyntax(Names);

            Console.WriteLine("**************  Non Query Syntax With Object (Book) *****************");

            List<Book> Books = new List<Book>()
            {
               new Book() { Id = 6 , Title = "C# Programming" , Author = "Lahcen AIT Taleb" },
               new Book() { Id = 4 , Title = "Python" , Author = "Soukaina Demghart"},
               new Book() { Id = 4 , Title = "Java Programming" , Author = "Soukaina Demghart"},
               new Book() { Id = 9 , Title = "JavaScript Programming" , Author = "Imane AIT Taleb"}

            };

            var listBookResults = Books.OrderBy(book => book.Id).ThenBy(book => book.Title);//.ThenBy(book => book);
            foreach (var book in listBookResults)
            {
                Console.WriteLine("Id : {0}, Title : {1}, Author : {2} ", book.Id,book.Title,book.Author);
            }

            Console.ReadLine();
        }
    }
}
