using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start ,end;
            //Insertion Sort
            start= DateTime.Now;
            int[] array ={ 5,2,4,6,1,3,1,2,3,12,23,14,15,45,44,22,33,66,77,88,99,19,10,99,88,678,987,456,765,234,123,5345,546,345,67,345,2,34,46,234,467,678,89,79070756,45623,555,26,475,71631153,2468,45,2,6,7,8,67542,334,14};
            
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j>=0 && key<array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[++j] = key;
            }

            foreach (var item in array)
            {
                Console.Write(item+"\t");
            }
            end = DateTime.Now;
            Console.WriteLine("Running time" + (end.Millisecond-start.Millisecond)+" milliseconds");

            //Selection Sort
            start = DateTime.Now;
            int[] array2 = { 5, 2, 4, 6, 1, 3, 1, 2, 3, 12, 23, 14, 15, 45, 44, 22, 33, 66, 77, 88, 99, 19, 10, 99, 88, 678, 987, 456, 765, 234, 123, 5345, 546, 345, 67, 345, 2, 34, 46, 234, 467, 678, 89, 79070756, 45623, 555, 26, 475, 71631153, 2468, 45, 2, 6, 7, 8, 67542, 334, 14 };
            int n=array2.Length;
            for (int i = 0; i < n-1; i++){
                int smallest = i;
                for (int j = i; j < n; j++){
                    if (array2[j] < array2[smallest]){
                        smallest = j;
                    }
                }
                int temp = array2[i];
                array2[i] = array2[smallest];
                array2[smallest]=temp;
            }

            foreach (var item in array2)
            {
                Console.Write(item + "\t");
            }
            end = DateTime.Now;
            Console.WriteLine("Running time" + (end.Millisecond - start.Millisecond) + " milliseconds");

            Console.Read();
        }
    }
}
