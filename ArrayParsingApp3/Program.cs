/**********************************************
 * The purpose of this code file is to take in
 * a given input string which is separated by a
 * delimiter value.  To remove all non-numeric
 * characters through parsing, and to output
 * a new delimiter separated string of int values
 **********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayParsingApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loopAgain = string.Empty; /*storing loop condition*/

            /**********************************************************
             * do while loop is initiated, allowing for multiple entries
             **********************************************************/
            do
            {
                /**********************************************************************
                 * Here we begin taking user input for the string and delimiter value
                 * Then we split the string into an array of elements via the delimiter
                 **********************************************************************/
                Console.WriteLine("---------------");
                Console.WriteLine("Enter string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine("Enter delimiter: ");
                char[] delimiterVal = Console.ReadLine().ToCharArray();
                string[] inputArray = inputString.Split(delimiterVal, StringSplitOptions.RemoveEmptyEntries);

                /*******************************************************************
                 * Now we iterate through our array using a for loop
                 *******************************************************************/
                for (int i = 0; i < inputArray.Length; i++)
                {
                    char[] chars = inputArray[i].Where(c => (char.IsDigit(c) || c == '.')).ToArray();/*numeric validation*/
                    string newChars = new string(chars);/*creating new string out of the validated characters*/
                    inputArray.SetValue($"{newChars}", i);/*modifying our original array with the new strings*/
                }

                /*****************************************************************
                 * Now that we have iterated through our array and removed all
                 * non-numeric characters.
                 * We simply create a new final string which joins each element
                 * of the modified initial array, and print that result.
                 *****************************************************************/
                string finalResult = string.Join(",", inputArray);
                Console.WriteLine(finalResult);

                /**********************************************
                 * Does the user wish to parse another string?
                 * If so and they answer correctly, our Do while
                 * loop condition will be satisfied.
                 **********************************************/
                Console.WriteLine("Parse again? [Y/y]: ");
                loopAgain = Console.ReadLine().ToUpper();


            } while (loopAgain == "Y");
        }
    }
}
