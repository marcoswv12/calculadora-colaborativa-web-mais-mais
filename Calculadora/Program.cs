using System;

class Program
{
    public static void Main(string[] args)
    {
        float a = 0;
        float b =0;
        
        char operação = "";
        
        Console.WriteLine("Calculadora");
        Console.WriteLine("Digite o seu primeiro valor:");
        a = Console.ReadLine();
        
        Console.WriteLine("Digite o seu segundo valor:");
        b = Console.ReadLine();
        
        Console.WriteLine("Digite o simbolo da sua operação:");
        operação = Console.ReadLine();
        
        if(operação == +)
        {
            soma();
        }
    }
  static float soma()
  {
  }
    static float subtração()
  {
  }
    static float divisão()
  {
  }
    static float multiplicação()
  {
  }
    static float porcentagem()
  {
  }
    static float potencia()
  {
  }
  
}
