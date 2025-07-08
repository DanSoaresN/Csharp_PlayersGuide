// Description: This program calculates the area of a triangle based on user input for height and base length.

//to store the user's input number you need to parse the string to a float
Console.WriteLine("Write the Base");
float TBaseNumber = float.Parse(Console.ReadLine());
Console.WriteLine("Write the Height");
float THeightNumber = float.Parse(Console.ReadLine());

Console.WriteLine("The Area of the Triangle is: " + CalculateArea(THeightNumber, TBaseNumber));


float CalculateArea(float height, float baseLength)
{
    return (height * baseLength) / 2;
}
