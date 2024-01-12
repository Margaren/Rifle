using Ak_47.Classes;
using AK_47.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AK_47.Tests
{
    public class USMTests
    {
        [Fact]
        public void CartridgeInTheChamber_Success()
        {
            var usm = new USM();
            var cartridge = new Cartridge();
            var checkCartidge = usm.Shoot(cartridge);

            Assert.Equal(true, checkCartidge.Used);
        }
        [Fact]
        public void Recharge_Success()
        {
            var usm = new USM();
            var cartridge = new Cartridge();
            usm.Shoot(cartridge);

            Assert.Throws<Exception>(() => usm.Shoot(cartridge));
        }
    }
}
