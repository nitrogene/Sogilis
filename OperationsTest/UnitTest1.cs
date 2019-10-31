using System;
using Xunit;
using Operations;

namespace OperationsTest
{
    public class UnitTest1
    {
        private readonly OperationService _operationService = new OperationService();


             
        [Fact]
        public void TestAdd()
        {
            var result = this._operationService.Add(1.0, 1.0);

            Assert.Equal(2.0, result, 8);
        }

        [Fact]
        public void TestDiv1()
        {
            var result = this._operationService.Div(1.0, 1.0);

            Assert.Equal(1.0, result, 8);
        }

        [Fact]
        public void TestDiv2()
        {
            var result = this._operationService.Div(1.0, 0.0);

            Assert.True(double.IsPositiveInfinity(result));
        }

        [Fact]
        public void TestDiv3()
        {
            var result = this._operationService.Div(-1.0, 0.0);

            Assert.True(double.IsNegativeInfinity(result));
        }

        [Fact]
        public void TestLog10()
        {
            var ex = Assert.Throws<NotImplementedException>(() => this._operationService.Log10(1.0));

            Assert.Equal("TODO", ex.Message);
        }
    }
}
