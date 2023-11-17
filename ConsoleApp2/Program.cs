using System;
using System.Collections;
using System.Collections.Generic;
namespace Arraylist2
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList Employeename = new ArrayList()
            {
                "Vidhya",
                "sasi",
                "Madhan",
                "Sahana" ,
                "shivani",
                "Priya",
                "Mahendran",
                "Narendiran"
            };
            if (Employeename != null)
            {



                Console.WriteLine("Employee Count:" + Employeename.Count);


                foreach (var name in Employeename)
                {


                    Console.WriteLine(name);


                }
            }
            
            //sorting arraylist
            
            Employeename.Sort();


            Console.WriteLine("-------------------------------------------------");
            if (Employeename != null)
            {


                Console.WriteLine("Arraylist after sorting.");

                foreach (var name in Employeename)
                {


                    Console.WriteLine(name);
                }
            }
            //Inserting a value
            Console.WriteLine("-------------------------------------------------");
            Employeename.Insert(4, "Divesh");
            if (Employeename != null)
            {


                Console.WriteLine("Arraylist after inserting a value.");
                foreach (var name in Employeename)
                {


                    Console.WriteLine(name);
                }
            }
            //created new array list and using insert at

            ArrayList temEmployeename = new ArrayList()
            {
                "Gopi",
                "jenica",
                "Mohana",
                "Namrata"
            };

            Employeename.InsertRange(9, temEmployeename);
            if (Employeename != null)
            {


                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Arraylist after inserting a value.");
                foreach (var name in Employeename)
                {


                    Console.WriteLine(name);
                }
            }

            //cloning the existing array
            ArrayList Employeenameclone New=




        }
    }
}      