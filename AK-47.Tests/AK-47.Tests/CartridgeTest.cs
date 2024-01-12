using AK_47.Classes;
using System;
using Xunit;

namespace AK_47.Tests
{
    public class CartridgeTest
    {
        public class CartridgesTests
        {
            [Fact]
            public void UseCartridge_Success()
            {
                var cartridge = new Cartridge();
                var position = cartridge.Used;
                cartridge.Use();
                Assert.Equal(position, !cartridge.Used);
            }
            [Fact]
            public void UseCartridge_Fail()
            {
                var cartridge = new Cartridge();
                cartridge.Use();
                Assert.Throws<Exception>(() => cartridge.Use());
            }
        }
    }
}
