//Exercicio 1:
int minAge = 20;
int maxAge = 50;
double mediumAge = (minAge + maxAge) / 2;

Console.WriteLine($"Idade média: {mediumAge}");
//Exercicio 2:
double EuroPrice = 5.29;
Console.WriteLine($"Preco do Euro: {EuroPrice}");
double RealPrice = 10;
double EuroToReal = EuroPrice * RealPrice;
Console.WriteLine($"{RealPrice} reais equivalem a {EuroToReal}");
//Exercicio 3:
double Sale = 500000;
double Commission = Sale * 0.05;
Console.WriteLine($"A comissão é de {Commission}");

//Exercicio 4:
double getFahrenheit(double Celsius)
{
    return (9 * Celsius + 160) / 5;
}
double Celsius = 10;
Console.WriteLine($"{Celsius} graus celsius equivalem a {getFahrenheit(Celsius)} graus Fahrenheit");
//Exercicio 5:
double getCelsius(double Fahrenheit)
{
    return (Fahrenheit - 32) * 5 / 9;
}
double Fahrenheit = 10;
Console.WriteLine($"{Fahrenheit} graus Fahrenheit equivalem a {getCelsius(Fahrenheit)} graus Celsius");


