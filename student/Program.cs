using System;
using System.Collections;
using System.Collections.Generic;
namespace student
{
    class program
    {


        static void Main(string[] args)
        {
            Name();
        }

        static void Name()
        {
            ArrayList studentname = new ArrayList();
            string? name;
            string student = "C:\\students\\details.txt";
            File.Create(student).Close();

            do
            {
                Console.WriteLine("Please enter the student name, To Quit == Enter Key");
                name = Console.ReadLine();

                studentname.Add(name);
            }
            while (name != "");
            Console.WriteLine("=================Display of student names============");
            foreach (var names in studentname)

            {
                if (names != "")
                {
                    Console.WriteLine("Student Name:" + names);
                    File.AppendAllText(student, "\nStudent Name:" + names);


                }

            }

            ArrayList studentid = new ArrayList();
            int id;
            

            do
            {
                Console.WriteLine("Please enter the student id, To Quit == Enter 0 key");
                id =Convert.ToInt32(Console.ReadLine());

                studentid.Add(id);
            } while (id > 0);
            foreach (int ids in studentid)
            { 

                        if (ids > 0)
                        {

                            Console.Write("\nStudent ID:"+ids);
                            
                        }

                    


            }
            
            





        }



    }
}