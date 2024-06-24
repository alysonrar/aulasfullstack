int horas;
Double valor, total;

Console.Write("Qual o valor da hora trabalhada ?: ");
valor = Double.Parse(Console.ReadLine());

Console.Write("Quantas Horas Trabalhadas ? :  ");
horas = int.Parse(Console.ReadLine());

total =  valor * horas;

Console.Write($"O valor total a ser recebido é de: R$ {total.ToString("f2")}");