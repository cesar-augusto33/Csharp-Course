using System; 

class URI {

    static void Main(string[] args) { 

    string[] values = Console.ReadLine().Split(' ');
    int A = int.Parse(values[0]);
    int B = int.Parse(values[1]);
    int C = int.Parse(values[2]);

    int majorAB = (A + B + Math.Abs(A - B)) / 2;
    int major = (majorAB + C + Math.Abs(majorAB - C)) / 2;

    Console.WriteLine(major + " eh o maior");

    }

}
