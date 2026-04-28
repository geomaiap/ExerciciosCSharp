// See https://aka.ms/new-console-template for more information
int N;
Console.WriteLine("Digite o valor de N:");
N = int.Parse(Console.ReadLine());
if(N <= 10)
{
    Console.WriteLine("F1");
}

else if(N >= 10 && N <= 100){
    Console.WriteLine("F2");
}

else{ 
    Console.WriteLine("F3");
}
