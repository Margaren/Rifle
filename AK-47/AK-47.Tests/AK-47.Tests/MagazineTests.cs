using System;
using Xunit;

namespace AK_47.Tests
{
    public class MagazineTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            const bool expectedUse = true;
            var cartridge = new Cartridge(expectedUse);
            //Act
            var actualUseCartridge = cartridge.UsedCartridge;
            //Assert
            Assert.Equal(expectedUse, actualUseCartridge);
        }
    }
}
