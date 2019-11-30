using System;

namespace bubble
{
    class Program
    {
        static void Main()
        {
            int[] arr = {6, 5, 3, 10, 8};
            bool swapped;

            foreach(int i in arr)
                Console.Write($"{i} ");
            
            do
            {
                swapped = false;
                for(int i = 0; i < arr.Length - 1; i++)
                {
                    if(arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }                    
                }

            } while(swapped == true);

            Console.WriteLine();

            for(int i = 0; i < arr.Length; i++)            
                Console.Write($"{arr[i]} ");            
        }
    }
}
