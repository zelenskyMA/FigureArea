namespace FigureAreaCalculation.Triangles
{
    /// <summary>
    /// Right triangle figure, used in Triangle representation.
    /// </summary>
    public class RightTriangle : Figure
    {
        protected override double Correction => 0.5;
        public RightTriangle(double sideA, double sideB) : base(sideA, sideB) { }
    }
}
