using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        List<long> fib = new List<long>();
        long a = 0, b = 1;
        for (int i = 0; i < n; i++) {
            fib.Add(a);
            long temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine(string.Join(" ", fib));
    }
}
