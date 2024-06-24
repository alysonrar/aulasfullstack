// See https://aka.ms/new-console-template for more information
Double distancia, velocidade, horas;
Console.WriteLine("Calcule o tempo de horas de sua viagem:                   ");

Console.Write("Digite a distãncia: ");
distancia = Double.Parse(Console.ReadLine());


Console.Write("Digite a velocidade: ");
velocidade = Double.Parse(Console.ReadLine());

horas = distancia/velocidade;

Console.WriteLine($"Você precisará de {horas} horas para chegar ao seu destino");