using System;
using System.Globalization;

namespace Exbeecrowd {
  class ExBee {
    static void Main(string[] args) {

      string text = Console.ReadLine();

      int contLetter = 0;
      int contWord = 1;
      int contPhrase = 0;

      for (int i = 0; i < text.Length; i++)
      {
        char lett = text[i];
        if((lett >= 'a' && lett <= 'z') || (lett >= 'A' && lett <= 'Z'))
        {
          contLetter++;
        }
        else if (lett == ' ')
        {
          contWord++;
        }
        else if (lett == '!' || lett == '.' || lett == '?') {
          contPhrase++;
        }
      }
      double L = (contLetter * 100.0) / contWord;
      double S = (contPhrase * 100.0) / contWord;
      double index = (0.0588 * L) - (0.296 * S) - 15.8;
      int intIndex = (int) Math.Round(index);

      if (index >= 16) 
      {
        System.Console.Write("(Grade 16+)");
      }
      else if (index < 1) 
      {
        System.Console.Write("(Before Grade 1)");
      }
      else 
      {
        for (int i = intIndex; i == intIndex; i++)
        {
        System.Console.WriteLine("(Grade " + intIndex + ")");
        }
      }
    }
  }
}
