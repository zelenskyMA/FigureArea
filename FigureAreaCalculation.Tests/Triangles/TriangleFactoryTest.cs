using FigureAreaCalculation.Triangles;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FigureAreaCalculation.Tests.Triangles
{
    public class TriangleFactoryTest
    {

        [Fact]
        public void TriangleFactory_DefineGenericTriangle_Success()
        {
            var figure = new TriangleFactory();

            Assert.True(figure.GetTriangle(2, 3, 4) is GenericTriangle);
        }

        [Fact]
        public void TriangleFactory_DefineRightTriangle_Success()
        {
            var figure = new TriangleFactory();

            Assert.True(figure.GetTriangle(1, 2, 2) is RightTriangle);
            Assert.True(figure.GetTriangle(2, 1, 2) is RightTriangle);
            Assert.True(figure.GetTriangle(2, 2, 1) is RightTriangle);
            Assert.True(figure.GetTriangle(2, 2, 2) is RightTriangle);
        }

        [Fact]
        public void TriangleFactory_DefineGenericTriangle_Failure()
        {
            var figure = new TriangleFactory();

            Assert.Null(figure.GetTriangle(1, 2, 3));
            Assert.Null(figure.GetTriangle(0, 2, 3));
            Assert.Null(figure.GetTriangle(1, -2, 3));
        }

    }
}
