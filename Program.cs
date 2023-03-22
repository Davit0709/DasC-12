using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[4];
        Random rnd = new Random();
        int sum = 0;

    
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rnd.Next(-100, 100);
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        for (int i = 1; i < arr.Length; i += 2) {
            sum += arr[i];
        }

        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}

