// See https://aka.ms/new-console-template for more information
string nome; 
int parafuso, porca, arruela;
double total, totalParafusos, totalPorcas, totalArruelas, precoParafuso, precoPorca, precoArruela, totalDesconto,
    descParafusos, descPorcas, descArruelas;

Console.WriteLine("Digite o nome do cliente: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a quantidade de parafusos: ");
parafuso = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de porcas: ");
porca = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de arruelas: ");
arruela = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço do parafuso: ");
precoParafuso = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço da porca: ");
precoPorca = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço da arruela: ");
precoArruela = double.Parse(Console.ReadLine());


totalParafusos = parafuso * precoParafuso * (20 / 100);
totalPorcas = porca * precoPorca * (10 / 100);
totalArruelas = arruela * precoArruela * (30 / 100);

descPorcas = totalParafusos * (20 / 100);
descPorcas = totalPorcas * (10 / 100);
descArruelas = totalArruelas * (30 / 100);

total = totalParafusos + totalPorcas + totalArruelas;
totalDesconto = descPorcas + descPorcas + descArruelas;

Console.WriteLine("Cliente: " + nome);
Console.WriteLine("Parafusos : " + parafuso);
Console.WriteLine("Porcas: " + porca);
Console.WriteLine("Arruelas: " + arruela);
Console.WriteLine("Total do desconto: " + totalDesconto);
Console.WriteLine("Total a pagar: " + total);
