// See https://aka.ms/new-console-template for more information
int cigarros, anos;
Double dias;
Console.WriteLine("Saiba em quantos dias a vida de um fumante é reduzida ao fumar um numero x de cigarros por x anos");

Console.Write("Escreva quantos cigarros por dia:");
cigarros = int.Parse(Console.ReadLine());

Console.Write("Qual a quantidade de anos:");
anos= int.Parse(Console.ReadLine());

cigarros = anos*365*cigarros;

dias =(Double) (cigarros*10) / 60 / 24;

Console.Write($"Foram perdidos {dias} dias de vida");