// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int A, B, C;
Console.WriteLine("Digite o valor de A: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
C = int.Parse(Console.ReadLine());

int soma = A + B;

if (soma > C)
{
    Console.WriteLine("A soma de A e B é maior que C");
}
else if (soma < C)
{
    Console.WriteLine("A soma de A e B é menor que C");
}

else
{
    Console.WriteLine("A soma de A e B é igual a C");
}

