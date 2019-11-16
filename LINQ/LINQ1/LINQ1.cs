using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace LINQ.LINQ1
{
    static class LINQ1
    {
        public static void WithoutLinq(List<string> Names)
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

        // Anonymous method
        public static void WithAnonymousMethod(List<string> Names)
        {
            IEnumerable<string> Results = Names.Where(delegate (string item) { return item.Length > 3;});
            ShowResults(Results);
        }

        // Query Syntax
        public static void WithLinq_QuerySyntax(List<string> Names)
        {
            IEnumerable<string> Results = from item in Names where item.Length > 3 select item;
            ShowResults(Results);
        }
        // Non Query Syntax
        public static void WithLinq_NonQuerySyntax(List<string> Names)
        {
            IEnumerable<string> Results = Names.Where(item => item.Length > 3).Where(item => item.Contains("i")).Take(2);
            ShowResults(Results);
        }


        private static void ShowResults(IEnumerable<string> listResults)
        {
            foreach (var name in listResults)
            {
                Console.WriteLine(name);
            }
        }
    }
}
