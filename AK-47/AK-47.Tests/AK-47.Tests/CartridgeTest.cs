using System;
using Xunit;
using AK47Classes;

namespace AK_47.Tests
{
    public class CartridgeTest
    {
        [Fact]
        public void UsedCartridge_Success()
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
