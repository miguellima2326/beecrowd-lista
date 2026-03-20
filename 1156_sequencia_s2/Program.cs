using System;
using System.Globalization;

// S = 1/1 + 3/2 + 5/4 + 7/8 + ... + 39/2^19
class Program {
    static void Main() {
        double s = 0;
        int num = 1;
        double den = 1;
        while (num <= 39) {
            s += num / den;
            num += 2;
            den *= 2;
        }
        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}
