double nota1; double nota2; double media;

Console.WriteLine("Insira a primeira nota: ");
nota1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2) / 2;

/*
if (media > 7)
{
    Console.WriteLine("Aprovado");
}
if (media <= 7 && media >5)
{
    Console.WriteLine("Recuperação");
}
if (media <= 5)
{
    Console.WriteLine("Reprovado");
}*/

//Ternario:

string result = media <= 5 ? "Reprovado" : "Aprovado";
Console.WriteLine(result);