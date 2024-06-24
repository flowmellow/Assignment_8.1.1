namespace Assignment_8._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 34, 72, 25, 0, 50, 70, 90, 108, 99 };
            int[] numbers = { 10, 7, 8, 9, 1, 6 };

            QuickSortArray quickSortArray = new QuickSortArray();

            quickSortArray.QuickSort(numbers, 0, numbers.Length - 1);

            quickSortArray.PrintArray(numbers);
        }
    }

    public class QuickSortArray
    {
        public void QuickSort(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                // The partition method we will still write helps us determine the index position of our pivot
                int pivotIndex = Partition(numbers, low, high);

                // Calling the QuickSort on numbers at the left hand side of pivot index
                QuickSort(numbers, low, pivotIndex - 1);

                // Calling the QuickSort() on numbers to the right hand side of pivot
                QuickSort(numbers, pivotIndex + 1, high);

            }
        }

        static int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[high]; //In this example we are choosing our pivot to be the last element in the array
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (numbers[j] <= pivot)
                {
                    i++;

                    // time to swap, always ensure you have a temporary variable storing your current value before you begin swapping
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
            //another swap outside the for loop
            //swap numbers[i+1] and numbers[high]
            int temp1 = numbers[i + 1];
            numbers[i + 1] = numbers[high];
            numbers[high] = temp1;
            return i + 1;

        }
        //finally the print array

        public void PrintArray(int[] numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
        }

    }
}
