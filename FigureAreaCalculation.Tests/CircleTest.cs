using FigureAreaCalculation.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FigureAreaCalculation.Tests
{
    public class CircleTest
    {
        [Fact]
        public void CircleArea_CommonValues_Success()
        {
            Assert.Equal(12.566, new Circle(2).GetArea());
            Assert.Equal(0.785375, new Circle(0.5).GetArea());
        }

        [Fact]
        public void CircleArea_BorderValues_Success()
        {
            Assert.Equal(0, new Circle(0).GetArea());
            Assert.Equal(0, new Circle(-2.5).GetArea());
        }
    }
}
