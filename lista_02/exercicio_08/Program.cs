// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

int valor1,valor2;
Double valor3;

Console.Write("Digite o primeiro valor: ");
valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
valor2 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
valor3 = Double.Parse(Console.ReadLine());

Console.WriteLine($"Letra A : {(valor1 * 2 )* (valor2 / 2)}");
Console.WriteLine($"Letra B: {(valor1 * 3) + valor3}");
//Console.Write($"Letra C : {valor3 * valor3 * valor3}");
Console.WriteLine($"Letra C : {Math.Pow(valor3 , 3)}");