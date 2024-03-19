using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        SwapLowerLeft(array);
        Console.WriteLine("\nМасив після обміну елементів у верхньому правому і нижньому лівому кутах:");
        PrintArray(array);

        SwapUpperLeft(array);
        Console.WriteLine("\nМасив після обміну елементів у нижньому правому і верхньому лівому кутах:");
        PrintArray(array);
    }

    static void PrintArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void SwapLowerLeft(int[,] arr)
    {
        int temp = arr[0, arr.GetLength(1) - 1];
        arr[0, arr.GetLength(1) - 1] = arr[arr.GetLength(0) - 1, 0];
        arr[arr.GetLength(0) - 1, 0] = temp;
    }

    static void SwapUpperLeft(int[,] arr)
    {
        int temp = arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
        arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1] = arr[0, 0];
        arr[0, 0] = temp;
    }
}
