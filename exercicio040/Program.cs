// See https://aka.ms/new-console-template for more information

int compra, pago, troco, resto, nota100, nota10, nota1;

Console.WriteLine("Digite o valor da compra: ");
compra = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor pago: ");
pago = int.Parse(Console.ReadLine());

troco = compra - pago;
resto = troco % 100;
nota100 = troco / 100;
nota10 = resto / 10;
nota1 = resto;

Console.WriteLine("O valor da  compra é: " + compra ) ;
Console.WriteLine("O valor pago é: " + pago);
Console.WriteLine("Troco: " + troco); 

Console.WriteLine("Quantidades de notas de 100: " +  nota100);
Console.WriteLine("Quantidades de notas de 10: " + nota10);
Console.WriteLine("Quantidades de notad de 1: " + nota1);