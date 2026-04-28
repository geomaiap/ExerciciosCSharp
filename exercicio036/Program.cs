// See https://aka.ms/new-console-template for more information "
using System.ComponentModel.Design;

float Port, Mat, CG, media, notas;
string nome;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a nota de Português: ");
Port = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota de Matemática: ");
Mat = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota de Conhecimentos Gerais: ");
CG = float.Parse(Console.ReadLine());
media = (Port + Mat + CG) / 3;

 Console.WriteLine(nome + ", sua note em português é  " + Port + ", sua nota em matematica é " + Mat + " e a nota " +
     "de Conhecimentos gerais é " + CG );
Console.WriteLine("A média das suas notas é: " + media);

if(media>7 & Port>=5 & Mat>= 5 & CG >= 5)
{
    Console.WriteLine("Parabéns, você foi aprovado!");
}


else
{
    Console.WriteLine("Infelizmente, você foi reprovado.");

}

