// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

int carrosvendidos;
Double valorcarro,salariofixo,comissao,salarioliquido;


Console.Write("Digite a quantidade de carros vendidos:");
carrosvendidos = int.Parse(Console.ReadLine());

Console.Write("Digite o valor do carro: R$");
valorcarro = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite o valor do salário fixo: R$");
salariofixo = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

comissao = (valorcarro * carrosvendidos) * 5 / 100;
salarioliquido = salariofixo + comissao;
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine($"Salário fixo : R$ {salariofixo.ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine($"Total vendas: R$ {(valorcarro * carrosvendidos).ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine($"Comissão: R$ {comissao.ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine($"Valor total: R$ {salarioliquido.ToString("F2" , CultureInfo.InvariantCulture)}");
Console.WriteLine("---------------------------------------------------------------------------");