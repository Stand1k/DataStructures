using HashTable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Denis" , Age = 21, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Dima" , Age = 35, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Andrew" , Age = 18, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Kitty" , Age = 24, Gender = 1 });
            superHashTable.Add(person);

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Denis", Age = 21, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));

            Console.ReadLine();


            var hashTable = new HashTable<int, string>(100);
            hashTable.Add(5, "Hello");
            hashTable.Add(18, "World");
            hashTable.Add(777, "Hi");
            //Colission
            hashTable.Add(7,"Wassup");

            Console.WriteLine(hashTable.Search(6, "KEK"));
            Console.WriteLine(hashTable.Search(18, "World"));

            Console.ReadLine();



            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            //Colission
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));

            Console.ReadLine();
        }
    }
}
