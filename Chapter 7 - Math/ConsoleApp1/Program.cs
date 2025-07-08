// See https://aka.ms/new-console-template for more information

double CalculateArea(double baseLength, double height)
{
    double area = 0.5 * baseLength * height;
    return area;
}

Console.WriteLine("Write the Base");
string TBase = Console.ReadLine();
double TBaseNumber = double.Parse(TBase);
Console.WriteLine("Write the Height");
string THeight = Console.ReadLine();
double THeightNumber = double.Parse(THeight);

Console.WriteLine("The Area of the Triangle is: " + CalculateArea(THeightNumber, TBaseNumber));
