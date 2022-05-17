//Exercicio 7:
double nota1;
double nota2;
double nota3;
double nota4;
Console.WriteLine("Insira a nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota: ");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota: ");
nota4 = double.Parse(Console.ReadLine());
double media = (nota1 + nota2 + nota3 + nota4) / 4;
if (media >= 7) {
    Console.WriteLine("Aprovado");
}else
{
    Console.WriteLine("Reprovado");
}




