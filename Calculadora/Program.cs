using System;
class Program
{
    static float Resultado = 0;
    static float a = 0;
    static float b = 0;

    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora");
        Console.WriteLine("Digite o seu primeiro valor:");
        a = float.Parse(Console.ReadLine());
        
       
        Console.WriteLine("Digite o simbolo da sua operação, (+,-,*,/,%,^):");
        char operação = char.Parse(Console.ReadLine()); 
        
        Console.WriteLine("Digite o seu segundo valor:");
        b = float.Parse(Console.ReadLine());
        
        if(operação == '+')
        {
            soma();
            Console.WriteLine(Resultado);
        }
        else if(operação == '-')
        {
            subtração();
            Console.WriteLine(Resultado);
        }
        else if(operação == '*')
        {
            multiplicação();
            Console.WriteLine(Resultado);
        }
        else if(operação == '/')
        {
            divisão();
            Console.WriteLine(Resultado);
        }

        else if(operação == '%')
        {
            porcentagem();
            Console.WriteLine(Resultado);
        }
        else if(operação == '^')
        {
            potencia();
            Console.WriteLine(Resultado);
        }
        else
        {
            Console.WriteLine("Operação invalida.");
            return;
        }
       


    }
    
  static void soma()
  {
      Resultado = a + b;
  }
    static void subtração()
  {
  }
    static void divisão()
  {
  }
    static void multiplicação()
  {
  }
    static void porcentagem()
  {
  }
    static void potencia()
  {
     Resultado = a ^ b;    
  }
  
}
