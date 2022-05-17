//Exercicio 1:
int minAge;
int maxAge;

Console.WriteLine("Insira a idade minima: ");
minAge = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a idade maxima: ");
maxAge = int.Parse(Console.ReadLine());
double mediumAge = (minAge + maxAge) / 2;

Console.WriteLine($"Idade média: {mediumAge}");

//Exercicio 2:
double EuroPrice;
double RealPrice;

Console.WriteLine("Preco do Euro: ");
EuroPrice = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de Reais");
RealPrice = double.Parse(Console.ReadLine());

double EuroToReal = EuroPrice * RealPrice;
Console.WriteLine($"{RealPrice} reais equivalem a {EuroToReal}");

//Exercicio 3:
double Sale;
Console.WriteLine("Venda:");
Sale = double.Parse(Console.ReadLine());
Console.WriteLine("Comissão em decimos:");
double Commission = double.Parse(Console.ReadLine());
double CommissionToEarn = Sale * Commission;
Console.WriteLine($"A comissão é de {CommissionToEarn}");

//Exercicio 4:
double getFahrenheit(double Celsius)
{
    return (9 * Celsius + 160) / 5;
}
Console.WriteLine("Graus celsius: ");
double Celsius = double.Parse(Console.ReadLine());
Console.WriteLine($"{Celsius} graus celsius equivalem a {getFahrenheit(Celsius)} graus Fahrenheit");

//Exercicio 5:
double getCelsius(double Fahrenheit)
{
    return (Fahrenheit - 32) * 5 / 9;
}
Console.WriteLine("Graus Fahrenheit: ");
double Fahrenheit = double.Parse(Console.ReadLine());
Console.WriteLine($"{Fahrenheit} graus Fahrenheit equivalem a {getCelsius(Fahrenheit)} graus Celsius");

