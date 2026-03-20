using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int a = Math.Min(x, y), b = Math.Max(x, y);
        for (int i = a; i <= b; i++)
            if (i % 5 == 2 || i % 5 == 3)
                Console.WriteLine(i);
    }
}
