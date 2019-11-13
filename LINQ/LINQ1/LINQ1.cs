using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ.LINQ1
{
    static class LINQ1
    {
        public static void WithoutLinq1(List<string> Names)
        {
            List<string> Results = new List<string>();

            for (int i = 0; i < Names.Count; i++)
            {
                if (Names[i].Length>3) 
                {
                    Results.Add(Names[i]);
                }
            }
            
            foreach (var name in Results)
            {
                Console.WriteLine(name);
            }
        }

        public static void WithLinq_QuerySyntax(List<string> Names)
        {
           var Results = from item in Names where item.Length > 3 select item;
            
            foreach (var name in Results)
            {
                Console.WriteLine(name);
            }
        }

        public static void WithLinq_NonQuerySyntax(List<string> Names)
        {
            var Results = Names.Where(item => item.Length > 3);

            foreach (var name in Results)
            {
                Console.WriteLine(name);
            }
        }
    }
}
