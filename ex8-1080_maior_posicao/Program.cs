using System;

class Program {
    static void Main() {
        int[] v = new int[100];
        for (int i = 0; i < 100; i++)
            v[i] = int.Parse(Console.ReadLine());
        int maior = v[0], pos = 1;
        for (int i = 1; i < 100; i++)
            if (v[i] > maior) { maior = v[i]; pos = i + 1; }
        Console.WriteLine(maior);
        Console.WriteLine(pos);
    }
}
