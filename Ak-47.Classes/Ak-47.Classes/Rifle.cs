using Ak_47.Classes;
using System;

namespace AK_47.Classes
{
    public class Rifle
    {
        public enum FireMode
        {
            Safety,
            SingleShot
        }
        public FireMode fireMode;
        private USM usm;
        public Magazine magazine;
        public int CartridgesCount => CountOfCartridges();
        public Rifle(Magazine magaz = null)
        {
            usm = new USM();
            magazine = magaz;
        }
        private int CountOfCartridges()
        {
            ThrowExceptionNullMagazine(magazine);
            return magazine.NumberOfCartridges_Magazine;
        }
        public void ReloadCartridges(Cartridge cartridge)
        {
            ThrowExceptionNullMagazine(magazine);
            magazine.Load(cartridge);
        }
        public Cartridge UnloadCartridges()
        {
            ThrowExceptionNullMagazine(magazine);
            return magazine.Unload();
        }
        public Cartridge CheckCurrentCartridgesInUSM()
        {
            return usm.CurrentCartridge;
        }
        public Cartridge Shot()
        {
            if (fireMode == FireMode.Safety)
            {
                throw new Exception("Автомат на предохранителе. Выстрел невозможен");
            }
            return usm.Shoot(UnloadCartridges());
        }
        public void ThrowExceptionNullMagazine(Magazine magazine)
        {
            if (magazine == null)
            {
                throw new Exception("Магазин не существует");
            }
        }
    }
}
