//Exercicio 9:
double A;
double B;
Console.WriteLine("Insira o valor A: ");
A = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor B: ");
B = double.Parse(Console.ReadLine());
if(A == 0 || B == 0)
{
    Console.WriteLine("Erro");
}
else {
    double total = A / B;
    double resto = A % B;
    Console.WriteLine(total);
    Console.WriteLine($"Resto: {resto}");
}

