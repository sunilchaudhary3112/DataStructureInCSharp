using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    class Sorting
    {
        public int[] array;
        int n;
        public Sorting(int size)
        {
            n = size;
            array = new int[size];
        }
        public void createRandomArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
        }
        public void swap (int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;

        }
        public void selectionSort()
        {
            int i, j, min_id;
            for(i = 0; i < n - 1; i++)
            {
                min_id = i;
                for(j = i+1; j < n ; j++)
                {
                    if(array[j] < array[min_id])
                    {
                        min_id = j;
                    }
                }
                swap(min_id, i);
            }
        }

        public void bubbleSort()
        {
            for (int i = 0; i < n - 1 ; i++ )
            {
                for (int j = 0; j < n -i -1 ; j++)
                {
                    if(array[j] > array [j+1])
                    {
                        swap(j,j+1);
                    }
                }
            }
        }

        public void display()
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(" " + array[i]);
            }
        }
        
    }
}
