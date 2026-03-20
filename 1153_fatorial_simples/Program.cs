using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        long fat = 1;
        for (int i = 2; i <= n; i++)
            fat *= i;
        Console.WriteLine(fat);
    }
}
