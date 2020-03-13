using FigureAreaCalculation.Triangles;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FigureAreaCalculation.Tests.Triangles
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleArea_CommonValues_Success()
        {
            Assert.Equal(2.90474, Math.Round(new Triangle(2, 3, 4).GetArea(), 5));
            Assert.Equal(1, Math.Round(new Triangle(1, 2, 2).GetArea(), 5));

            Assert.Equal(1.5, Math.Round(new Triangle(1.5, 2, 2).GetArea(), 5));
            Assert.Equal(0.94992, Math.Round(new Triangle(1, 2.5, 2).GetArea(), 5));
            Assert.Equal(0.72618, Math.Round(new Triangle(1, 2, 1.5).GetArea(), 5));
        }

        [Fact]
        public void TriangleArea_BorderValues_Success()
        {
            Assert.Equal(0, new Triangle(0, 2, 3).GetArea());
            Assert.Equal(0, new Triangle(1, 0, 2).GetArea());
            Assert.Equal(0, new Triangle(1, 2, 0).GetArea());

            Assert.Equal(0, new Triangle(-1, 2, 3).GetArea());
            Assert.Equal(0, new Triangle(1, -1, 2).GetArea());
            Assert.Equal(0, new Triangle(1, 2, -1).GetArea());
        }

    }
}
