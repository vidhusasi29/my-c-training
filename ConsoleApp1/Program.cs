using System;
using System.Collections;
using System.Xml.Linq;

namespace arraylist1
{
    class program
    {
        static void Main(string[]args)
        {
            ArrayList list = new ArrayList();
            int X;
            do
            {

                Console.WriteLine("Please enter a Integer value, To Quit == Enter 0 Key");
                X =Convert.ToInt32( Console.ReadLine());

                list.Add(X);

            }while (X > 0);
            int sum = 0;
            foreach (var i in list)
            {
                sum +=Convert.ToInt16( i);
            }
            Console.WriteLine(sum);
        }
    }
}