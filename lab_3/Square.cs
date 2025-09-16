namespace lab_3;

class Square : Shape
{
    public double SideLength { get; init; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double square()
    {
        return Math.Round(Math.Pow(SideLength, 2),2);
    }

    public override string ToString()
    {
        return $"Сторона квадрата: {SideLength}\n" +
            $"Площадь: {square()}\n";
    }
}