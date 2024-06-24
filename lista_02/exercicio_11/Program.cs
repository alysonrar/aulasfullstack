// See https://aka.ms/new-console-template for more information
int totaleleitores , validos , nulos , brancos;

Console.Write("insira o número total de eleitores: ");
totaleleitores = int.Parse(Console.ReadLine());

Console.Write("insira o número de votos em branco: ");
brancos = int.Parse(Console.ReadLine());

Console.Write("insira o número de votos nulos: ");
nulos = int.Parse(Console.ReadLine());

Console.Write("insira o número de votos válidos: ");
validos = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------RESULTADOS----------------------");
Console.WriteLine($"Total de eleitores: {totaleleitores}");
Console.WriteLine($"Percentual de votos em Branco: {brancos*100/totaleleitores}%");
Console.WriteLine($"Percentual de votos nulos: {nulos*100/totaleleitores}%");
Console.WriteLine($"Percentual de votos válidos: {validos*100/totaleleitores}%");
Console.WriteLine("-----------------------------------------------------------");