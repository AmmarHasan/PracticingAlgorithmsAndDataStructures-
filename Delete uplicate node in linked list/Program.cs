using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticingAlgorithmsAndDataStructures1;//Added refernce by right clicking on the project
namespace Delete_uplicate_node_in_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbersArray = {32, 16, 90, 13, 0, 80, 20, 92, 77, 77, 25, 9, 73, 100, 63, 55, 34, 17, 17, 74, 83, 59, 39, 9, 53, 52, 84, 63, 34, 46, 25, 85, 7, 43, 18, 94, 34, 53, 61, 7, 76, 33, 95, 65, 30, 90, 84, 72, 0, 88, 17, 95, 58, 81, 100, 72, 66, 87, 43, 24, 6, 5, 82, 62, 93, 86, 54, 88, 59, 61, 2, 92, 40, 83, 82, 25, 60, 38, 58, 21, 62, 12, 13, 98, 48, 56, 100, 78, 83, 61, 81, 66, 72, 39, 75, 45, 26, 81, 59, 91 };
            
            List<int> numbersList = numbersArray.ToList<int>(), temporaryList = new List<int>(), positions= new List<int>();
            IEnumerator myEnumerator = numbersList.GetEnumerator();
            int i = 0,j=0,lengthWhenDuplicatesAreRemoved=0;
            while ((myEnumerator.MoveNext()) && (myEnumerator.Current != null)) {
                
                int currentValue=(int)myEnumerator.Current;
                if (temporaryList.Contains(currentValue))
                {
                    positions.Add(i);
                }
                else {
                    temporaryList.Add(currentValue);
                    lengthWhenDuplicatesAreRemoved++;
                }
                i++;
            }
            j = lengthWhenDuplicatesAreRemoved;
            while(j>0)
            {
                numbersList.RemoveAt(j);
                j--;
            }
            Console.Write(lengthWhenDuplicatesAreRemoved);
            Console.Read();
            
        }
    }
}
