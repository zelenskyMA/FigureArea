using FigureAreaCalculation.BusinessEntities;

namespace FigureAreaCalculation.Triangles
{
    /// <summary>
    /// Represents Triangle figure.
    /// Defines triangle type by factory and returns it's area
    /// </summary>
    public class Triangle
    {
        private IFigure TriangleObject { get; }
        private TriangleFactory TriangleFactorySrv { get; }

        public double GetArea() => TriangleObject?.GetArea() ?? 0;

        public Triangle(double sideA, double sideB, double sideC)
        {
            TriangleFactorySrv = new TriangleFactory();
            TriangleObject = TriangleFactorySrv.GetTriangle(sideA, sideB, sideC);
        }

    }
}
