using System; 

class URI {

    static void Main(string[] args) { 

      int N, age, month, day, rest;

      N = int.Parse(Console.ReadLine());

      age = N / 365;
      rest = N % 365;
      Console.WriteLine(age + " ano(s)");

      month = rest / 30;
      rest = rest % 30;
      Console.WriteLine(month + " mes(es)");

      day = rest;
      Console.WriteLine(day + " dia(s)");
    }
}
