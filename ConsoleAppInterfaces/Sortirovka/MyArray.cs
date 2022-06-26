using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.Sortirovka
{
    internal class MyArray
    {
        private int[] _array;

        public MyArray(params int[] numbers)
        {
            _array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                _array[i] = numbers[i];
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Sort(IMyComparator myComparator)
        {
            bool isSorted;
            int offset = 0;

            do
            {
                isSorted = true;
                for (int i = 0; i < _array.Length - 1 - offset; i++)
                {
                    if (myComparator.Compare(_array[i], _array[i + 1]) == true)
                    {
                        isSorted = false;

                        int temp = _array[i];
                        _array[i] = _array[i + 1];
                        _array[i + 1] = temp;
                    }
                }

                offset++;

            } while (isSorted == false);
        }



    }
}
