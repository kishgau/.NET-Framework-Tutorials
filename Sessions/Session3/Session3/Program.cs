using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr1 = new int[10];
            //int[] arr2 = { 10, 20, 30 };


            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add("sTRING1");

            //Console.WriteLine(arrayList[1]);
            //Console.WriteLine(arrayList[0]);

            //List<string> list1 = new List<string>();

            //list1.Add("xyz");

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "string1");



            //dict[1] = "string2";

            //sorting
            //Console.WriteLine("staeted");
            //int[] arr1 = { 5, 6, 9, 1, 10 };

            //int i;

            //int temp; 

            //for ( i = 0; i < arr1.Length; i++ )
            //{
            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (arr1[i] > arr1[j])
            //        {
            //            temp = arr1[i];
            //            arr1[i] = arr1[j];
            //            arr1[j] = temp;

            //        }
            //    }

            //}

            //Console.WriteLine("sa");

            //foreach(int x in arr1)
            //{
            //    Console.WriteLine(x);
            //}



            fact(5);

        }

        public static int fact(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * fact(n + 1);
        }



    }
}
