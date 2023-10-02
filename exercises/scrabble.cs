using System;
using System.Globalization;

namespace Exbeecrowd {
  class ExBee {
    static void Main(string[] args) {

      //Pontos para cada letra do alfabeto
      int[] POINTS = {1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10};
      
      //Armazena cada palavra digitada pelo usuário
      string word1 = Console.ReadLine();
      string word2 = Console.ReadLine();

      //Calcula o valor de cada palavra através da função CalcScore
      int score1 = CalcScore(word1, POINTS);
      int score2 = CalcScore(word2, POINTS);

      //Condição para verificar qual palavra tem mais pontos
      if (score1 == score2)
      {
        System.Console.WriteLine("Tie!");
      }
      else if (score1 > score2)
      {
        System.Console.WriteLine("Player 1 wins!");
      }
      else
      {
        System.Console.WriteLine("Player 2 wins!");
      }
    }
    static int CalcScore (string word, int[] array) //Função para realizar o cálculo da soma
    {
      int score = 0;
      for (int i = 0; i < word.Length; i++) //Loop para percorrer por toda a palavra digitada pelo usuário
      {
        char lett = word[i]; //Armazena em char lett a letra do indice i
        if ((lett >= 'a' && lett <= 'z') || (lett >= 'A' && lett <= 'Z')) //Verificar se os caracteres são letras
        {
          char upLett = Char.ToUpper(lett); //Transforma as letras todas em maiúsculas
          int indice = upLett - 'A'; //Encontra o indice de cada letra do alfabeto ('A' - 'A' = 0 ...)
          score += array[indice]; //Soma todos os valores de cada letra
        }
      }
      return score; //retorna o valor da soma
    }
  }
}
