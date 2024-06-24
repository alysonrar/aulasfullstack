// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o seu salário abaixo para saber o novo valor com o reajuste de 12%");
Double salário = Double.Parse(Console.ReadLine());
Double novosalario = salário / 100 * 12+ salário;
Console.WriteLine($"O seu salário que antes do reajuste era {salário} e agora é no valor de {novosalario}");

