using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Create two arrays - one with int and other with chars and then create Dictionary 
namespace AssignmentQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise array_nums : 1 to 26
            // initialise array_chars A to Z

            int[] array_nums = new int[26];
            char[] array_chars = new char[26];

            Dictionary<int, char> dict = new Dictionary<int, char>();

            for (int counter = 0; counter <= 25 ; counter++)
            {
                array_nums[counter] = counter + 1;
                array_chars[counter] = (char) (97 + counter);// explicit typecastinAQ
                                 

            }

            Zip(array_nums, array_chars);

            // Debug : Check array contents 
            //for (int counter = 0; counter <=25; counter++)
            //{
            //    Console.WriteLine(array_nums[counter]);
            //    Console.WriteLine(array_chars[counter]);
            //}

            // function ZIP
            void Zip(int[] A, char[] B)
            {

                for (int counter = 0; counter <= 25; counter++)
                {
                    dict.Add(array_nums[counter], array_chars[counter]);
                }
            }

            List<string> list1 = new List<string>(;

          


            foreach (KeyValuePair<int,char> kvp in dict )
            {

                Console.WriteLine(kvp.Key + "-" + kvp.Value);
               
            }

             Console.ReadLine();
           

        }
    }
}
