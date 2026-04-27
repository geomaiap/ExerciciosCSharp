// See https://aka.ms/new-console-template for more information
string nome;
float Nota1, Nota2, Total;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a Nota 1:");
Nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a Nota 2:");
Nota2 = float.Parse(Console.ReadLine());
Total = Nota1 + Nota2;

if (Total >= 60)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}



