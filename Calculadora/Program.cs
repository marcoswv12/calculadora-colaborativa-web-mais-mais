using System;

class Program
{
    public static void Main(string[] args)
    {

        float Resultado = 0;
        
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
            Console.WriteLine(Resultado);
        }
        else if(operação == '-')
        {
            subtração();
            Console.WriteLine(Resultado);
        }
        else if(operação == '*')
        {
            divisão();
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
        }


    }
    
  static float soma()
  {
  }
    static float subtração()
  {
        Resultado = a-b;
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
