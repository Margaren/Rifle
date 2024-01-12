using AK_47.Classes;
using System;
using Xunit;

namespace AK_47.Tests
{
    public class RifleTests
    {
        [Fact]
        public void Shot_Success()
        {
            var magazine = new Magazine();
            for (int i = 0; i < 3; i++)
            {
                magazine.Load(new Cartridge());
            }
            var rifle = new Rifle(magazine);
            rifle.fireMode = Rifle.FireMode.SingleShot;
            var countKalash = rifle.CartridgesCount;
            var v = countKalash - 1;
            rifle.Shot();

            Assert.Equal(v, rifle.CartridgesCount);
        }

        [Fact]
        public void Shot_Fail()
        {
            var magazine = new Magazine();
            for (int i = 0; i < 3; i++)
            {
                magazine.Load(new Cartridge());
            }
            var kalash = new Rifle(magazine);
            var countKalash = kalash.CartridgesCount;

            Assert.Throws<Exception>(() => kalash.Shot());
        }

        [Fact]
        public void NullMagazineTest()
        {
            var kalash = new Rifle();
            var cartridge = new Cartridge();
            kalash.fireMode = Rifle.FireMode.SingleShot;

            Assert.Throws<Exception>(() => kalash.ReloadCartridges(cartridge));
        }
    }
}
