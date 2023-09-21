using System; 

class URI {

    static void Main(string[] args) { 

      int N = int.Parse(Console.ReadLine());
      int rest = N;

      int time = 3600;
      int hour = rest / time;
      rest = rest % time;

      time = 60;
      int min = rest / time;
      rest = rest % time;

      int sec = rest;

      Console.WriteLine(hour + ":" + min + ":" + sec);
    }
}
