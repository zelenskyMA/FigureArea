namespace FigureAreaCalculation
{
    /// <summary>
    /// Represents circle figure
    /// </summary>
    public class Circle : Figure
    {
        protected override double Correction => 3.1415;

        public Circle(double radius) : base(radius, radius) { }
    }
}
