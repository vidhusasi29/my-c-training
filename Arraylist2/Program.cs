using System;
using System.Collections;
using System.Collections.Generic;
namespace Arraylist2
{

    class GFG
    {

        // Driver code 
        public static void Main()
        {

            
            ArrayList myList = new ArrayList();

            // Adding elements to ArrayList 
            myList.Add('a'); 
            myList.Add('b');
            myList.Add('c');
            myList.Add('d');
            myList.Add('e');
            myList.Add('f');
            myList.Add('g');
            myList.Add('h');
            Console.WriteLine("Enter a alphabet value to check its existance in the arraylist.");
            char letter =Convert.ToChar( Console.ReadLine());
           
           
            if (myList.Contains(letter))
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("e"));
            else
                Console.WriteLine("No, doesn't exists");
        }
    }
}