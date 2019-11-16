using System;
using System.Collections.Generic;
using LINQ.LINQ1;

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


            Console.ReadLine();
        }
    }
}
