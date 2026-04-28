// See https://aka.ms/new-console-template for more information
float A, B, C, total;
Console.WriteLine("Digite a primeira nota:");
A = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
B = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
C = float.Parse(Console.ReadLine());
total = ((A * 2)+ (B * 3) +(C * 5) / 10);
Console.WriteLine("A média ponderada é: " + total);
