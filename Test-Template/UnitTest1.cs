using Test_Template;
using Whiteboard_Template;

namespace Test_Template
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "World")]
        [InlineData(2, "World1")]
        [InlineData(3, "World2")]
        [InlineData(4, "World3")]
        public void Test1(int logicInput, string expected)
        {
            //Arrange
            var logic1 = new Actual_Logic();

            //Act
            var actual = logic1.Logic(logicInput);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}