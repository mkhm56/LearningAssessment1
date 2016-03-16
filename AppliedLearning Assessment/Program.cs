using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedLearning_Assessment
{
    class Program
    {
        static void Main(string[] args)
        /* This is the answer to #1

            Console.WriteLine("Please enter a number.");
            int numInput = int.Parse(Console.ReadLine());
            
            if (numInput < 10)            
            {
                Console.WriteLine("This number is too small.");
            }
            else if (numInput >= 10)
            {
                Console.WriteLine("This number is big enough.");
            } */


        // This is the answer to #2

        /* {
               float[] decimals = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };

               Console.WriteLine(decimals[decimals.Length - 4]); //5-3 
         } */


        //  *THIS is THE ANSWER TO #3


        /*  float[] decimals = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
          foreach (float i in decimals)
          {
              Console.Write("{0}  ", i);
          }

      } */

        //THIS IS THE ANSWER FOR #4
        {
          
            Console.WriteLine("Please enter  a number between 1 and 100.");
            int num = int.Parse(Console.ReadLine());
      
            switch (num)

            {
                case 1: //if num = 1
                    Console.WriteLine("Only one?");
                    break;
                case 100: //if num = 100
                    Console.WriteLine("100? That's a lot!");
                    break;
                default:  
                    Console.WriteLine("Input not recognized.");
                    break;

            }
        }
    }
 }
        


