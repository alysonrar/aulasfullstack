// See https://aka.ms/new-console-template for more information
int dias, horas ,minutos ,segundos;

Console.Write("Quantidade de dias : ");
dias = int.Parse(Console.ReadLine());

Console.Write("Quantidade de horas : ");
horas = int.Parse(Console.ReadLine());

Console.Write("Quantidade de minutos : ");
minutos = int.Parse(Console.ReadLine());

Console.Write("Quantidade de segundos : ");
segundos = int.Parse(Console.ReadLine());

horas = horas +(dias*24); 
minutos = minutos +(horas*60); 
segundos = segundos +(minutos*60); 

Console.Write($"O valor convertido em segundos é : {segundos}");
