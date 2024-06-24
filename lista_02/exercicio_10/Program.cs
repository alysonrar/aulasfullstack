using System;
using System.Globalization;

Double valorhoras , salariobruto , salarioliquido,ir,inss,sindicato;
int horastrabalhadas;

Console.Write("digite o valor por hora: ");
valorhoras = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("digite quantas horas trabalhadas: ");
horastrabalhadas = int.Parse(Console.ReadLine());
/*+ Salário Bruto        : R$
- IR (11%)                : R$
- INSS (8%)             : R$
- Sindicato ( 5%)      : R$
= Salário Liquido      : R$
*/
salariobruto = valorhoras * horastrabalhadas;
ir = salariobruto *11 /100;
inss = salariobruto * 8 / 100;
sindicato = salariobruto * 5 / 100;
salarioliquido = salariobruto -(ir + inss + sindicato);

Console.WriteLine("-----------FOLHA DE PAGAMENTO---------------");
Console.WriteLine($"Salário Bruto        : R${salariobruto.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"IR (11%)             : R${ir.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"INSS (8%)            : R${inss.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Sindicato ( 5%)      : R${sindicato.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Salário Liquido      : R${salarioliquido.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine("-------------------------------------------");