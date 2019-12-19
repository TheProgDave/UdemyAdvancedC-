using System;

namespace Generics
{
    
    public class Utilities
    {
        public int Max(int first, int second)
        {
            return first > second ? first : second;
        }
        // 5 major constraints:
        // where T : IComparable
        // where T : [insert_class_name_here]
        // where T : struct // must be a value-type
        // where T : class  // must be a reference-type
        // where T : new()  // must have a default constructor



        public T Max<T>(T first, T second) where T : IComparable //You can create generic methods inside a non-generic class.
        {
            return first.CompareTo(second) > 0 ? first : second;
        }

    }






// Generics provide built in 
   public class Book
   {
   }

   public class GenericDictionary<TKey, TValue>
   {
       public void Add(TKey key, TValue value)
       {
           /*if (key == null) throw new ArgumentNullException(nameof(key));
           if (value == null) throw new ArgumentNullException(nameof(value));*/
       }

       public TValue this[TKey key] => throw new NotImplementedException();
    }

   public class GenericList<T>
   {
       public void Add(T value)
       {

       }

       public T this[int index] => throw new NotImplementedException();
   }




   class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new GenericDictionary<string,Book>();
            dictionary.Add("1234",new Book());
        }
    }
}
