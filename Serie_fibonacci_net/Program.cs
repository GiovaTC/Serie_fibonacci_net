using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de términos de la serie Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Fibonacci(n);
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un numero entero positivo");
        }
    }

    static void Fibonacci(int n)
    {
        long a = 0, b = 1, temp;

        Console.WriteLine($"Serie Fibonacci hasta {n} terminos:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            temp = a;
            a = b;
            b = temp + b;
        }
        Console.WriteLine();
    }
}
                
    
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
               

