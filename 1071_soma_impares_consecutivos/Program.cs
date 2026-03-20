using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int a = Math.Min(x, y), b = Math.Max(x, y);
        int soma = 0;
        for (int i = a; i <= b; i++)
            if (i % 2 != 0)
                soma += i;
        Console.WriteLine(soma);
    }
}
