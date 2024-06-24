// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Valor Máximo e Minimo\n");
//valor maximo
//int IntMaximo = int.MaxValue;
//valor minimo
// sbyte -128 a 127
//sbyte Valor_sbyte = 127;
//Console.WriteLine($"sbyte:  {Valor_sbyte}");
//Console.WriteLine($"sbyte:  {Valor_sbyte}");
//byte 0 a 225
//byte ValorByte = (Byte) Valor_sbyte;
//Console.WriteLine($"byte: {ValorByte}");
//int @int = 10;
//Console.WriteLine(@int);

using System.Globalization;

double valor1, valor2;
Console.WriteLine("Digite um valor");
valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite outro valor");
valor2= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Valor:  {(valor1 + valor2).ToString("F2", CultureInfo.InvariantCulture)}");

//+ - * / ++ -- %

Console.WriteLine($"Soma:            {(valor1 + valor2)}");
Console.WriteLine($"Subtração:       {(valor1 - valor2)}");
Console.WriteLine($"Multriplicação:  {(valor1 * valor2)}");
Console.WriteLine($"Divisão:         {(valor1 / valor2)}");

//valor2 = valor1 + 1;
Console.WriteLine($"Adição²:         {(valor1++)}");
Console.WriteLine($"Adição²:         {(++valor1)}");

//valor1 = valor1 -1;
Console.WriteLine($"Subtração²:      {(valor1--)}");
Console.WriteLine($"Subtração²:      {(--valor1)}");

//resto da divisão
Console.WriteLine($"Módulo:  4 / 3   {(4 % 3)}");

