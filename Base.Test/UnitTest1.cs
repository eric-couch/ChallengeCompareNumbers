using Base.App;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;

namespace Base.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CompareNumbers_Test_Success()
        {
            // Arrange
            int x = 5;
            int y = 10;
            string result = "x is less than y is true";

            var baseAppType = typeof(Program);
            Assert.NotNull(baseAppType);
            var compareNumbersMethod = baseAppType.GetMethod("CompareNumbers", BindingFlags.Public | BindingFlags.Static);
            Assert.NotNull(compareNumbersMethod);

            // Act
            var actual = (string)compareNumbersMethod.Invoke(null, new object[] { x, y })!;

            // Assert
            Assert.Equal(result, actual.ToLower());
        }

        [Fact]
        public void CompareNumbers_Test_Fail()
        {
            // Arrange
            int x = 10;
            int y = 5;
            string result = "x is less than y is false";

            var baseAppType = typeof(Program);
            Assert.NotNull(baseAppType);
            var compareNumbersMethod = baseAppType.GetMethod("CompareNumbers", BindingFlags.Public | BindingFlags.Static);
            Assert.NotNull(compareNumbersMethod);

            // Act
            var actual = (string)compareNumbersMethod.Invoke(null, new object[] { x, y })!;

            // Assert
            Assert.Equal(result, actual.ToLower());
        }
    }
}