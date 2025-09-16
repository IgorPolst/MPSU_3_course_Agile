namespace lab_3;

class Triangle : Shape
{
    public double TriangleBase { get; init; }
    public double Height { get; init; }

    public Triangle(double triangleBase, double height)
    {
        TriangleBase = triangleBase;
        Height = height;
    }

    public override double square()
    {
        return Math.Round(Height * TriangleBase * 0.5, 2);
    }

    public override string ToString()
    {
        return $"Основание треугольника: {TriangleBase}\n" +
            $"Высота: {Height}\n" + 
            $"Площадь: {square()}\n";
    }
}