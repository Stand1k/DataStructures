using Map.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var map =  new Map<int, string>();
            map.Add(new Item<int, string>(1,"One"));
            map.Add(new Item<int, string>(1,"One"));
            map.Add(new Item<int, string>(2,"Two"));
            map.Add(new Item<int, string>(3,"Three"));
            map.Add(new Item<int, string>(4,"Four"));
            map.Add(new Item<int, string>(5,"Five"));
            map.Add(new Item<int, string>(101,"Hundred and one"));

            foreach(var item in map)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(map.Search(7) ?? "Not found");
            Console.WriteLine(map.Search(3) ?? "Not found");
            Console.WriteLine(map.Search(101) ?? "Not found");

            map.Remove(7);
            map.Remove(3);
            map.Remove(1);
            map.Remove(101);

            foreach(var item in map)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
