// See https://aka.ms/new-console-template for more information
Double nota1, nota2, nota3, nota4, resultado;
Console.WriteLine("Insira as notas abaixo para saber sua média" );

Console.Write("Digite a primeira nota: "); 
nota1 = Double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: "); 
nota2 = Double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota:"); 
nota3 = Double.Parse(Console.ReadLine());

Console.Write("Digite a quarta nota: "); 
nota4 = Double.Parse(Console.ReadLine());

resultado = (nota1 + nota2 + nota3 + nota4) / 4;

Console.Write($"A média é:  {resultado} ");