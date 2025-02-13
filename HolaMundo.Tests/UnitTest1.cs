using Xunit;
using HolaMundo;

namespace HolaMundo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSaludar()
        {
            string resultado = Program.Saludar();
            Assert.Equal("Hola Mundo!", resultado);
        }
    }
}
