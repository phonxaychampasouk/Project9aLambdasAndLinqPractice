using System;
using System.Collections.Generic;
using System.Linq;

namespace project9a
{
    class Program
    {
        // AN expression which takes no parameters and evaluates to the string "Hello,World".

        



        // An Expression wchich returns an interer, takes a single integer parameter, and adds the interfer 1 to it.




        //An expression whic returns an integer, takes two interfer parameters and sums them.




        // An expression which returns an intefer, takes two intefer parameters and sums them







        //An expression which returns a string, takes two strings, and appends the first to the second.



        static void Main(string[] args)
        {// AN expression which takes no parameters and evaluates to the string "Hello,World".

   Func<string> question1 = () => "Hello, World";
            Console.WriteLine("Question 1: "+ question1());



            // An Expression wchich returns an interer, takes a single integer parameter, and adds the interfer 1 to it.

            Func<int, int> question2 = b => b + 1;
            Console.WriteLine("Question 2: " + question2(5));


            //An expression whic returns an integer, takes two integers parameters and raises the second parameter to the power of the first.

            Func<int,int,int> question3 = (d, e) => e ^ d;
            Console.WriteLine("Question 3: " + question3(1,2));


            // An expression which returns an intefer, takes two intefer parameters and sums them
           

   Func<int, int, int> question4 = (l,k) => l + k;
            Console.WriteLine("Question 4: " + question4(5,10));


            //An expression which returns a string, takes two strings, and appends the first to the second.


            Func<string, string, string> question5 = (x, y) => x + y;
            Console.WriteLine("Question 5: " + question5("hello","darkness"));

            //----------------------------LINQ----------------------------------

            

             
            List<string> slowAnimals = new List<string> { "turtle", "sloth", "manatee", "dung beetle" };


            var ListofInt = Enumerable.Range(1, 10);
            
            
            {
                Console.WriteLine(number + 1);
            }


            




        }

    }
}



//Func<int> f = () => 7;