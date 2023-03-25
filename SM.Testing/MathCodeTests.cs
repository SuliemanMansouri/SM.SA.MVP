using SM.MathContracts;
using SM.MathImplementation;

namespace SM.Testing
{
    public class MathCodeTests
    {
        readonly IMathCode _mathCode;

        public MathCodeTests()
        {
            _mathCode = new MyMathLibrary();
        }

       
        [Fact]
        public void TestAdd_ResultShouldBeThree()
        {
            //Arrange
            int a = 1;
            int b = 2;

            //Act
            int c = _mathCode.Add(a, b);

            //Assert
            Assert.Equal(3, c);

        }

        [Fact]
        public void TestSubtract_ResultShouldBe0()
        {
            //Arrange
            int a = 1;
            int b = 1;

            //Act
            int c = _mathCode.Subtract(a, b);

            //Assert
            Assert.Equal(0, c);

        }

        [Fact]
        public void TestMultiply_ResultShouldBeThree()
        {
            //Arrange
            int a = 1;
            int b = 3;

            //Act
            int c = _mathCode.Multiply(a, b);

            //Assert
            Assert.Equal(3, c);

        }

        [Fact]
        public void TestDivide_ResultShouldBeThree()
        {
            //Arrange
            int a = 6;
            int b = 2;

            //Act
            int c = _mathCode.Divide(a, b);

            //Assert
            Assert.Equal(3, c);

        }

        [Fact]
        public void TestDivide_divideByZero_ThrowsException()
        {
            //Arrange
            int a = 6;
            int b = 0;
            
            //Act, Assert
            Assert.Throws<DivideByZeroException>(() => _mathCode.Divide(a, b));

        }
    }
}