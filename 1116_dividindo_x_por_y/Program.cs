using System;
using System.Globalization;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string[] p = Console.ReadLine().Split(' ');
            int x = int.Parse(p[0]);
            int y = int.Parse(p[1]);
            if (y == 0)
                Console.WriteLine("divisao impossivel");
            else
                Console.WriteLine(((double)x / y).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
