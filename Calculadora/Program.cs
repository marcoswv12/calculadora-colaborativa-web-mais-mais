using System;

class Program
{
    /// <summary> Armazena o resultado da operação. </summary>
    static float Resultado = 0;

    /// <summary> Primeiro número inserido pelo usuário. </summary>
    static float a = 0;

    /// <summary> Segundo número inserido pelo usuário. </summary>
    static float b = 0;

    public static void Main(string[] args)
    {
        /// <summary> Método principal: solicita dois números e a operação desejada, e exibe o resultado. </summary>
        /// <example> Exemplo: Usuário digita 2, depois '+', depois 3. O programa exibe 5. </example>
        Console.WriteLine("Calculadora");

        Console.WriteLine("Digite o seu primeiro valor:");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o símbolo da sua operação (+, -, *, /, %, ^):");
        char operação = char.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu segundo valor:");
        b = float.Parse(Console.ReadLine());

        if (operação == '+')
        {
            Soma();
            Console.WriteLine(Resultado);
        }
        else if (operação == '-')
        {
            Subtracao();
            Console.WriteLine(Resultado);
        }
        else if (operação == '*')
        {
            Multiplicacao();
            Console.WriteLine(Resultado);
        }
        else if (operação == '/')
        {
            Divisao();
            Console.WriteLine(Resultado);
        }
        else if (operação == '%')
        {
            Porcentagem();
            Console.WriteLine(Resultado);
        }
        else if (operação == '^')
        {
            Potencia();
            Console.WriteLine(Resultado);
        }
        else
        {
            Console.WriteLine("Operação inválida.");
        }
    }

    /// <summary> Soma os valores de a e b. </summary>
    static void Soma()
    {
        Resultado = a + b;
    }

    /// <summary> Subtrai b de a. </summary>
    static void Subtracao()
    {
        Resultado = a - b;
    }

    /// <summary> Divide a por b. </summary>
    static void Divisao()
    {
        Resultado = a / b;
    }

    /// <summary> Multiplica a por b. </summary>
    static void Multiplicacao()
    {
        Resultado = a * b;
    }

    /// <summary> Calcula b por cento de a. </summary>
    static void Porcentagem()
    {
        Resultado = (b * a) / 100;
    }

    /// <summary> Calcula a elevado à potência b usando a biblioteca de matematica (MathF.Pow()). </summary>
    static void Potencia()
    {
        Resultado = MathF.Pow(a, b);
    }
}
