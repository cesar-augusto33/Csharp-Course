using System; 

class URI {

    static void Main(string[] args) { 

        int x = 100;
        int value = int.Parse(Console.ReadLine());
        int rest = value % x;

        int a = value / 100;
        int b = rest / 50;
        rest = rest % 50;
        int c = rest / 20;
        rest = rest % 20;
        int d = rest / 10;
        rest = rest % 10;
        int e = rest / 5;
        rest = rest % 5;
        int f = rest / 2;
        rest = rest % 2;
        int g = rest / 1;

        Console.WriteLine(value);
        Console.WriteLine(a + " nota(s) de R$ 100,00");
        Console.WriteLine(b + " nota(s) de R$ 50,00");
        Console.WriteLine(c + " nota(s) de R$ 20,00");
        Console.WriteLine(d + " nota(s) de R$ 10,00");
        Console.WriteLine(e + " nota(s) de R$ 5,00");
        Console.WriteLine(f + " nota(s) de R$ 2,00");
        Console.WriteLine(g + " nota(s) de R$ 1,00");
    }
}
