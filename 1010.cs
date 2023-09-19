using System; 

class URI {

    static void Main(string[] args) { 

       string prodA = Console.ReadLine();
       string prodB = Console.ReadLine();

       string[] list1 = prodA.Split(' ');
       string cod1 = list1[0];
       string numb1 = list1[1];
       string price1 = list1[2];

       double numb1Double = double.Parse(numb1);
       double price1Double = double.Parse(price1);

       string[] list2 = prodB.Split(' ');
       string cod2 = list2[0];
       string numb2 = list2[1];
       string price2 = list2[2];

       double numb2Double = double.Parse(numb2);
       double price2Double = double.Parse(price2);


       double valueProdA = numb1Double*price1Double;
       double valueProdB = numb2Double*price2Double;

       double valor = valueProdA + valueProdB;

       Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2"));

    }

}
