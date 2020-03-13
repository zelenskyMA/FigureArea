using FigureAreaCalculation.BusinessEntities;
using System.Collections.Generic;
using System.Linq;

namespace FigureAreaCalculation.Triangles
{
    /// <summary>
    /// Triangle type definition factory
    /// </summary>
    public class TriangleFactory
    {
        public IFigure GetTriangle(double sideA, double sideB, double sideC)
        {
            var sides = new List<double> { sideA, sideB, sideC };

            if (!TriangleExists(sides))
                return null;

            var differentSides = sides.Distinct();
            if (differentSides.Count() < 3)
            {
                var first = differentSides.ElementAt(0);

                if (differentSides.Count() == 1)
                    return new RightTriangle(first, first);
                else
                    return new RightTriangle(first, differentSides.ElementAt(1));
            }

            return new GenericTriangle(sideA, sideB, sideC);
        }

        private bool TriangleExists(List<double> sides)
        {
            if (sides.Any(t => t <= 0))
                return false;

            if (sides[0] + sides[1] > sides[2]
                && sides[0] + sides[2] > sides[1]
                && sides[1] + sides[2] > sides[0])
                return true;

            return false;
        }

    }
}
