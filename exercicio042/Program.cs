// See https://aka.ms/new-console-template for more information
float salario, salarioF, ComCarros, ComVendas, salarioTotal; ;
int carros, vendas;

Console.WriteLine("Digite o valor do salário: ");
salario = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de corros vendidos: ");
carros = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor total das vendas: ");
vendas = int.Parse(Console.ReadLine());



salarioF = salario * 2;
ComCarros = carros * 50;
ComVendas = vendas * (5 / 100);
salarioTotal = salarioF + ComCarros + ComVendas;

Console.WriteLine("Salário fixo:" + salarioF );
Console.WriteLine("Comissão por carros vendidos: " + ComCarros);
Console.WriteLine("Comissão por vendas: " + ComVendas);

Console.WriteLine("Salário total: " + salarioTotal);