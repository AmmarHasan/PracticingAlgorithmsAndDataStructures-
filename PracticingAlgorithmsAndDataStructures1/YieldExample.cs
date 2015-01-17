using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithmsAndDataStructures1
{
    class YieldExample
    {
        public YieldExample()
        {
            foreach (int value in ComputePower(2, 30))
            {
                Console.Write(value);
                Console.Write(" ");
            }
            Console.WriteLine();

        }


        private IEnumerable<int> ComputePower(int number, int exponent)
        {

            int exponentNum = 0;
            int numberResult = 1;
            //
            // Continue loop until the exponent count is reached.
            //
            while (exponentNum < exponent)
            {
                //
                // Multiply the result.
                //
                numberResult *= number;
                exponentNum++;
                //
                // Return the result with yield.
                //
                yield return numberResult;
            }
        }
    }
}

