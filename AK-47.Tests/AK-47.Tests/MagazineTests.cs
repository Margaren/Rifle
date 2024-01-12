using AK_47.Classes;
using System;
using Xunit;

namespace AK_47.Tests
{
    public class MagazineTests
    {
        [Fact]
        public void MagazineLoadTest()
        {
            var magazine = CreateMagazine(30);
            Assert.Throws<Exception>(() => magazine.Load(new Cartridge()));
        }
        [Fact]
        public void MagazineUnloadTest()
        {
            var magazine = CreateMagazine(0);
            Assert.Throws<Exception>(() => magazine.Unload());
        }
        [Fact]
        public void MagazineSuccessfulLoad()
        {
            var magazine = CreateMagazine(16);
            var cartCount = magazine.NumberOfCartridges_Magazine;
            var v = cartCount + 1;
            magazine.Load(new Cartridge());
            Assert.Equal(v, magazine.NumberOfCartridges_Magazine);
        }
        [Fact]
        public void MagazineSuccessfulUnload()
        {
            var magazine = CreateMagazine(16);
            var cartCount = magazine.NumberOfCartridges_Magazine;
            var v = cartCount - 1;
            magazine.Unload();
            Assert.Equal(v, magazine.NumberOfCartridges_Magazine);
        }
        private Magazine CreateMagazine(int count)
        {
            var magazine = new Magazine();
            for (int i = 0; i < count; i++)
            {
                magazine.Load(new Cartridge());
            }
            return magazine;
        }
    }
}
