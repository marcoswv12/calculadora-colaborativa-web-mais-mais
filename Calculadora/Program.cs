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
        
        Console.WriteLine("Digite o simbolo da sua operação, (+,-,*,/,%,^):");
        operação = Console.ReadLine();
        
        if(operação == +)
        {
            soma();
        }
        else if(operação == -)
        {
            subtração();
        }
        else if(operação == *)
        {
            divisão();
        }
        else if(operação == /)
        {
            divisão();
        }
        else if(operação == %)
        {
            porcentagem();
        }
        else if(operação == ^)
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
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Calculadora de Divisão");
            
            try
            {
                Console.Write("Digite o primeiro numero:");
                float num1 = float.Parse(Console.ReadLine());
                
                Console.Write("Digite o segundo numero:");
                float num2 = float.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("Erro: a divisão por zero não é permitida.");
                }
                else
                {
                    float resultado = Dividir(num1, num2);
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
            }
            catch (FormatException erro)
            {
                Console.WriteLine("Erro: Você digitou um valor invalido. Use apenas numeros.");
            }
            
            Console.Write("\nDeseja fazer outra divisão? (s/n):");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
            {
                continuar = false;
            }
        }
        Console.WriteLine("Encerrando a calculadora. Até logo!");
    }
    static float Dividir(float x, float y)
                         {
                             return x/y;
                         }
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
