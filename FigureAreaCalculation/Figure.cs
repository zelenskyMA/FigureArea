using FigureAreaCalculation.BusinessEntities;
using System;

namespace FigureAreaCalculation
{
    /// <summary>
    /// Generic figure class for area calculation
    /// </summary>
    public abstract class Figure : IFigure
    {
        protected virtual double Correction => 1;
        private double MiltiplierA { get; }
        private double MultiplierB { get; }


        public double GetArea()
        {
            if (Correction < 0 || MiltiplierA < 0 || MultiplierB < 0)
                return 0;

            return Correction * MiltiplierA * MultiplierB;
        }

        public Figure(double miltiplierA, double miltiplierB)
        {
            MiltiplierA = miltiplierA;
            MultiplierB = miltiplierB;
        }

    }
}
