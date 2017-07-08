using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrometest2
{
    public class Program
    {
        static void ValidationCheck(ref string t1)
        {
            //string t2 = t1;

            //Console.WriteLine("debug// String is: " + t1);

            if (t1 == "")
            {
                Console.WriteLine("String cannot be empty.");
            }
            else
            {
                //exit function back to main
                
            }
        }

        static void TestPalindrome(ref string testP)
        {
            //split char's into array of two
            //test each position in array matches the other
            //if it does return palindrome
            //if it does not return try another word

            var chars1 = testP.ToCharArray();
            var chars2 = testP.ToCharArray();


            //reverse string into var's for testing
            //reverse chars2 so it can be tested
            Array.Reverse(chars2);

            /*
            //debug start
            Console.WriteLine("Original string: " + testP);
            Console.WriteLine("Character array:");

            for (int ctr = 0; ctr < chars1.Length; ctr++)
            {
                Console.WriteLine("   {" + ctr + "} " + chars1[ctr]);
            }
            //debug end
            */

            //test the character arrays to see if they match
            int endWhile = chars1.Length-1;
            int n = 0;
            int pal = 0;
            //Console.WriteLine(endWhile);

            for (n = 0; n < chars1.Length; n++)
            {
                if(chars1[n] == chars2[n])
                {
                    //characters are the same then continue
                    //Console.WriteLine("char1= " + chars1[n] + " chars2= " + chars2[n]);

                    pal++;
                }
                else
                {
                    Console.WriteLine("This is not a palindrome, your entry was: " + testP);
                    Console.WriteLine("It's characters were...");
                    Console.WriteLine("Forward:");
                    for (n = 0; n < chars1.Length; n++)
                    {

                        Console.WriteLine("char1= " + chars1[n]);
                    }

                    Console.WriteLine("Backward:");
                    for (n = 0; n < chars2.Length; n++)
                    {

                        Console.WriteLine("char2= " + chars2[n]);
                    }
                }
            }

            if(pal == chars1.Length)
            {
                Console.WriteLine("This is a palindrome and your entry was: " + testP);
                Console.WriteLine("It's characters were...");
                Console.WriteLine("Forward:");
                for (n = 0; n < chars1.Length; n++)
                {

                    Console.WriteLine("char1= " + chars1[n]);
                }

                Console.WriteLine("Backward:");
                for (n = 0; n < chars2.Length; n++)
                {

                    Console.WriteLine("char2= " + chars2[n]);
                }

            }


                
        }

        //scope public // static means? // return value // function name // paramaters
        static void Main()
        {
            string strInput = "nothing";

            Console.WriteLine("Please enter a Palindrome to test.");

            strInput = Console.ReadLine();

            ValidationCheck(ref strInput);

            //flatten capitalisation of string
            string strFlatten = "flat";
            strFlatten = strInput.ToLower();

            //Console.WriteLine("debug // string lower " + strFlatten);

            TestPalindrome(ref strFlatten);

         
            

            //end of program

        }
    }
}
