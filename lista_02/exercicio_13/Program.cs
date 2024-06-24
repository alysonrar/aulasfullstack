// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

Double Biologia,Portugues,Matematica,Mediatotal;

Console.Write("insira a nota de Biologia: ");
Biologia = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("insira a nota de Português: ");
Portugues = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("insira a nota de Matemática: ");
Matematica = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Mediatotal = ((Biologia*2)+(Portugues*3)+(Matematica*5))/10;

Console.WriteLine("------------------------------------------------------------------------------------------------------");
Console.WriteLine($"A nota de Biologia foi de : {Biologia.ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine($"A nota de Português foi de : {Portugues.ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine($"A nota de Matemática foi de : {Matematica.ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine($"Sua média final nessas matérias foi de: {Mediatotal.ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine("------------------------------------------------------------------------------------------------------");