using System;
using System.Linq;

namespace CocktailSort
{
    class Program
    {
        static void Main()
        {
            int[] numsToSort = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int end = numsToSort.Length - 1;
            int temp;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < end; i++)
                {
                    if (numsToSort[i] > numsToSort[i + 1])
                    {
                        temp = numsToSort[i];
                        numsToSort[i] = numsToSort[i + 1];
                        numsToSort[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }

                swapped = false;
                end -= 1;

                for (int i = end; i >= start; i--)
                {
                    if (numsToSort[i] > numsToSort[i + 1])
                    {
                        temp = numsToSort[i];
                        numsToSort[i] = numsToSort[i + 1];
                        numsToSort[i + 1] = temp;
                        swapped = true;
                    }
                }

                start += 1;
            }

            Console.WriteLine(string.Join(", ", numsToSort));
        }
    }
}
