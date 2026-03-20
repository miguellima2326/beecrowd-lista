using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int coelhos = 0, ratos = 0, sapos = 0;
        for (int i = 0; i < n; i++) {
            string[] p = Console.ReadLine().Split(' ');
            int qtd = int.Parse(p[0]);
            char tipo = p[1][0];
            if (tipo == 'C') coelhos += qtd;
            else if (tipo == 'R') ratos += qtd;
            else if (tipo == 'S') sapos += qtd;
        }
        int total = coelhos + ratos + sapos;
        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {(coelhos * 100.0 / total):F2} %");
        Console.WriteLine($"Percentual de ratos: {(ratos * 100.0 / total):F2} %");
        Console.WriteLine($"Percentual de sapos: {(sapos * 100.0 / total):F2} %");
    }
}
