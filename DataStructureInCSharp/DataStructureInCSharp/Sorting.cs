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
            //temp = new int[size];
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
        public void insertionSort()
        {
            int key, j;

            for(int i = 1; i < n; i++)
            {
                key = array[i];
                j = i - 1;
                while(j>=0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
        public void mergeSort(int[] temp, int left, int right)
        {
            int mid;
            if(left < right)
            {
                mid = (left + right) / 2;
                mergeSort(temp, left, mid);
                mergeSort(temp, mid + 1, right);
                merge(temp, left, mid + 1, right);
            }
        }
        public void merge(int[] temp, int left, int mid, int right)
        {
            int left_end, temp_pos, size;
            left_end = mid - 1;
            temp_pos = left; 
            size = right - left + 1;

            while((left <= left_end ) && (mid <= right))
            {
                if(array[left] < array[mid])
                {
                    temp[temp_pos] = array[left];
                    temp_pos++;
                    left++;
                }
                else
                {
                    temp[temp_pos] = array[mid];
                    temp_pos++;
                    mid++;
                }
            }
            while(left<= left_end)
            {
                temp[temp_pos] = array[left];
                temp_pos++;
                left++;
            }
            while(mid <= right)
            {
                temp[temp_pos] = array[right];
                temp_pos++;
                mid++;
            }

            for(int i = 0; i < size; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
        public void quickSort(int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(low, high);
                quickSort(low, pi - 1);
                quickSort(pi + 1, high);
            }
        }
        public int Partition(int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for(int j = low; j <= high - 1; j++)
            {
                if(array[j] <= pivot)
                {
                    i++;
                    swap(i, j);
                }
            }
            swap(i + 1, high);
            return i + 1;
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
