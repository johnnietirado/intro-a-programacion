using System;

namespace Codealo {
  class Program {
    public static void Main(string[] args) {
      // Verdadera o Falsa

      int vida = 0;
      int dmg = 0;

      // == Igual a
      // != No Es igual
      // > Mas grande que
      // < Mas pequeño que
      // && Y (And)
      // || O (Or)

      if(vida > 0 && dmg < vida) {
        Console.WriteLine("Estas vivo");
      } else {
        Console.WriteLine("Estas muerto... 💀");
      }

      
    }
  }
}