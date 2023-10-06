using System;

class Programa

{
	static void Main()
	{
        Console.WriteLine("Digite um Número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro Número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num * num2;
        if(resultado == 0) { Console.WriteLine("Número Inválido: "); }
        if(resultado == 1) { Console.WriteLine("Número Inválido: "); }
        if(resultado == 2) { Console.WriteLine("Número Inválido: "); }
        if(resultado == 3) { Console.WriteLine("Número Inválido: "); }

        Console.WriteLine($"O resultado dessa multiplicação é: {resultado}");

        Console.ReadKey();
    }
}