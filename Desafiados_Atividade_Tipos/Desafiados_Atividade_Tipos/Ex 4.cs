//Exercicio 4:
double getFahrenheit(double Celsius)
{
    return (9 * Celsius + 160) / 5;
}
double Celsius = 10;
Console.WriteLine($"{Celsius} graus celsius equivalem a {getFahrenheit(Celsius)} graus Fahrenheit");
