namespace tringle
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;

        //конструктор с параметрами, используем this
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //метод проверки существования треугольника
        public bool IsValid()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        //метод вывода сторон
        public string PrintSides()
        {
            return $"Стороны: a={a}, b={b}, c={c}";
        }
    }
}