// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva um número para saber seu sucessor e antecessor:");
int valor = int.Parse(Console.ReadLine());
int antecessor = valor -1 ;
int sucessor = valor +1;
Console.WriteLine($"o antecessor de {valor} é {antecessor} e o sucessor de {valor} é {sucessor} ");

