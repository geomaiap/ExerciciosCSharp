// See https://aka.ms/new-console-template for more information
int A, B, C, Aux;
Console.WriteLine("Digite o valor de A:");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B:");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C:");
C = int.Parse(Console.ReadLine());

if(A > B)
{
    Aux = A;
    A = B;
    B = Aux;
}
 if(A > C)
{
    Aux = A;
    A = C;
    C = Aux;
}

 if(B > C)
{
    Aux = B;
    B = C;
    C = Aux;
}

    Console.WriteLine("A ordem crescente é: " + A + ", " + B + ", " + C);
