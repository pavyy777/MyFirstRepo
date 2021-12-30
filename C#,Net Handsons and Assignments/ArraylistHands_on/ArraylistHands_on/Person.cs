using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraylistHands_on
{
    class Person
    {
        public void PersonDetails()
        {

            ArrayList PersList = new ArrayList();
            
            ArrayList perslist2 = new ArrayList();
            string personName = Console.ReadLine();
            string personAge = Console.ReadLine();
            string personName2 = Console.ReadLine();

            string personAge2 = Console.ReadLine();

            string personName3 = Console.ReadLine();
            string personAge3 = Console.ReadLine();


            PersList.Add(personName);
            PersList.Add(personAge);
            PersList.Add(personName2);
            PersList.Add(personAge2);
            PersList.Add(personName3);
            PersList.Add(personAge3);
            for (int i = 0; i < PersList.Count; i++)
            {
                
                Console.WriteLine(PersList[i]);
            }
            //for (int i = 0; i < 6; i++)
            //{
            // PersList.WriteLine(a);
           // Console.WriteLine(PersList);
            



        }




    }
 } 

   /* string personName2 = Console.ReadLine();

    string personAge2 = Console.ReadLine();

    string personName3 = Console.ReadLine();
    string personAge3 = Console.ReadLine();


    PersList.Add(personName);
                 PersList.Add(personAge);
                 PersList.Add(personName2);
                PersList.Add(personAge2);
                PersList.Add(personName3);
                PersList.Add(personAge3);

                //for (int i = 0; i < 6; i++)
                //{
                // PersList.WriteLine(a);
                Console.WriteLine(PersList);
        */    