using AK_47.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ak_47.Classes
{
    public class USM
    {
        public Cartridge CurrentCartridge { get; private set; }

        public USM(Cartridge cartridges = null)
        {
            CurrentCartridge = cartridges;
        }

        public bool CheckCartridgesInUSM()
        {
            if (CurrentCartridge == null)
            {
                return false;
            }
            return true;
        }
        public void LoadCartridgesInUSM(Cartridge cartridge)
        {
            ThrowExceptionInUSM(CheckCartridgesInUSM());
            CurrentCartridge = cartridge;
        }

        public Cartridge Shoot(Cartridge cartridge)
        {
            LoadCartridgesInUSM(cartridge);
            CurrentCartridge.Use();
            var currentCartridges = CurrentCartridge;
            return currentCartridges;
        }

        public void ThrowExceptionInUSM(bool cartridgesInUsm)
        {
            if (cartridgesInUsm)
            {
                throw new Exception("В автомате уже есть пуля");
            }
        }
    }
}
