using System;

class Program {
    static void Main() {
        for (int i = 1; i <= 9; i += 2) {
            int startJ = i + 6;
            for (int j = startJ; j >= startJ - 2; j--)
                Console.WriteLine($"I={i} J={j}");
        }
    }
}
