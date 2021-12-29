using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
			Hashtable numberNames = new Hashtable();
			numberNames.Add(1, "One"); //adding a key/value using the Add() method
			numberNames.Add(2, "Two");
			numberNames.Add(3, "Three");

			//The following throws run-time exception: key already added.

			//for (int i = 0; i < numberNames.Count; i++)
			//{
			//	Console.WriteLine(numberNames[i]);
			//}
			foreach (DictionaryEntry kvp in numberNames)
			{
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
			}
			//creating a dictionary using collection-initializer syntax
			var cities = new Hashtable(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
			};

			foreach (DictionaryEntry kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		}
	}
}
    

