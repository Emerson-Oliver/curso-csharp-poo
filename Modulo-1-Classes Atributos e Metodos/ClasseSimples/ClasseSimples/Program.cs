using System.Globalization;

namespace ClasseSimples;

class Program
{
    static void Main(string[] args)
    {
        double xA, xB, xC, yA, yB, yC, areaX, areaY, p;

        Console.WriteLine("Entre com as medidas do triangulo X: ");
        xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triangulo Y: ");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        p = (xA + xB + xC) / 2.0;
        areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2.0;
        areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

        Console.WriteLine($"Area de X = {areaX.ToString("F4",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

        if(areaX > areaY)
        {
            Console.WriteLine("Maior área e a X");
        }
        else
        {
            Console.WriteLine("Maior área e a Y");
        }
    }
}