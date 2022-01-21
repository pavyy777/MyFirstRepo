using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable2
{
    class Program
    {
        static void Main(string[] args)
        {

          
          /*    Hashtable Characteristics:
             
        *  HashTable is Non-Generic collection
        * Hashtable stores key-value pairs. 
        * Comes under System.Collection namespace.
        * Keys must be unique and cannot be null.
        * Values can be null or duplicate.
        * Values can be accessed by passing associated key in the indexer e.g.Ht[key]
        * Elements are stored as DictionaryEntry objects.
           */
        
            Hashtable Ht = new Hashtable();
            Ht.Add("abc", "One");
            Ht.Add(22, "TwoTwo");
            Ht.Add(3, "Three");
            Console.WriteLine(  H] );
            Hashtable clone = Ht.Clone() as Hashtable;
            Ht.Remove(125);
            Ht.Add("xyz", 123);
            Console.WriteLine(Ht.Contains("ab"));
           // Ht.Clear();
           //clone.Clear();
            Console.WriteLine("--Number Hashtable--");

            //The Hashtable is a collection. We can use the foreach loop to go through all the items and read them using they Key and Value properties.
            
            foreach (DictionaryEntry item in Ht)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
              }  
           
           Console.WriteLine("\nclone of number Hashtable\n");
            foreach (DictionaryEntry item in clone)
           {
                
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
