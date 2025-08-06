using System;

class Program
{
    public static void Main(string[] args)
    {
        float a = 0;
        float b =0;
        
        
        Console.WriteLine("Calculadora");
        Console.WriteLine("Digite o seu primeiro valor:");
        a = Console.ReadLine();
        
       
        Console.WriteLine("Digite o simbolo da sua operação, (+,-,*,/,%,^):");
        char operação = Console.ReadLine(); 
        
        Console.WriteLine("Digite o seu segundo valor:");
        b = Console.ReadLine();
        
        if(operação == '+')
        {
            soma();
        }
        else if(operação == '-')
        {
            subtração();
        }
        else if(operação == '*')
        {
            divisão();
        }
        else if(operação == '/')
        {
            divisão();
        }
        else if(operação == '%')
        {
            porcentagem();
        }
        else if(operação == '^')
        {
            potencia();
        }
        else
        {
            Console.WriteLine("Operação invalida.");
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
