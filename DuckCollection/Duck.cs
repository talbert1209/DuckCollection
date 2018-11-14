using System;

namespace DuckCollection
{
    public class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public void Quack()
        {

        }

        public void Swim()
        {

        }

        public void Eat()
        {

        }

        public void Walk()
        {

        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            if (this.Size < duckToCompare.Size)
                return -1;
            return 0;
        }
    }
}