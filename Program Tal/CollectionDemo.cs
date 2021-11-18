using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;                                          


        


namespace Program_Tal
{
    public class CollectionDemo
    {
        public static void Run()
        {
            Console.WriteLine("CollectionDemo");  
            
        var exePath = Path.GetDirectoryName(
                typeof(CollectionDemo).Assembly.Location);

        var filename = Path.Combine(exePath, "Data", "MOCK_DATA.json");

        var text = File.ReadAllText(filename);

        var people = JsonConvert.DeserializeObject<List<Person>>(text);


        var firstPeople = people.Skip(10).Take(10);

            foreach (var p in firstPeople)
            {
                Console.WriteLine(p);

                Console.WriteLine();
                Console.WriteLine("Names:");
                Console.WriteLine();

                var names = people
                    .Select(p => $"{p.last_name} {p.first_name}");

                foreach (var name in names.Skip(1).Take(2))

                {
                    Console.WriteLine(name);
                }
                var x = 1;
                var y = 2;
                if (x < y)
                {
                    Console.WriteLine("x smaller");


                }
            }

            


        }        
    }
}
