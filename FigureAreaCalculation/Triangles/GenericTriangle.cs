using FigureAreaCalculation.BusinessEntities;
using System;
using System.Linq;

namespace FigureAreaCalculation.Triangles
{
    /// <summary>
    /// Generic triangle figure, used in Triangle representation.
    /// </summary>
    public class GenericTriangle : IFigure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public double GetArea()
        {
            var sides = new double[] { 0, SideA, SideB, SideC };
            double halfPerimeter = sides.Sum() / 2;
            var multValue = sides.Aggregate(1.0, (p, x) => p * (halfPerimeter - x));

            return Math.Sqrt(multValue);
        }

        public GenericTriangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

    }
}
