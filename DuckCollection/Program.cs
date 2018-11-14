using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCollection
{
    class Program
    {
        public static void PrintDucks(List<Duck> listOfDucks)
        {
            foreach (var duck in listOfDucks)
            {
                Console.WriteLine($"{duck.Size} -inch {duck.Kind}");
            }

            Console.WriteLine("End of ducks!");
        }

        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() {Kind = KindOfDuck.Decoy, Size = 14},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() {Kind = KindOfDuck.Decoy, Size = 13},
            };

            Console.WriteLine("Before sort:");
            PrintDucks(ducks);

            //Sort ducks with IComparable<T>
            //ducks.Sort();

            //Sort ducks with IComparer
            var duckSizeComparer = new DuckComparerBySize();
            ducks.Sort(duckSizeComparer);

            Console.WriteLine("After sort by size:");
            PrintDucks(ducks);

            var duckKindCompare = new DuckComparerByKind();
            ducks.Sort(duckKindCompare);

            Console.WriteLine("After sort by kind:");
            PrintDucks(ducks);

            DuckComparer duckComparer= new DuckComparer();
            duckComparer.SortBy = DuckComparer.SortCriteria.KindThenSize;
            ducks.Sort(duckComparer);
            Console.WriteLine("After fancy sort:");
            PrintDucks(ducks);

            Console.ReadKey();
        }
    }
}
