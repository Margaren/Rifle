using System;
using System.Collections.Generic;

namespace AK_47.Classes
{
    //Магазин
    public class Magazine
    {
        private int MaxNumberOfCartridges_Magazine;
        private Stack<Cartridge> countCartridges = new Stack<Cartridge>();
        public int NumberOfCartridges_Magazine => countCartridges.Count;
        public Magazine(int maxCartridges = 30)
        {
            MaxNumberOfCartridges_Magazine = maxCartridges;
        }

        public void Load(Cartridge cartridge)
        {
            if (NumberOfCartridges_Magazine >= MaxNumberOfCartridges_Magazine)
            {
                throw new Exception("Заряжается пуль больше, чем возможно");
            }
            countCartridges.Push(cartridge);
        }
        public Cartridge Unload()
        {
            if (NumberOfCartridges_Magazine == 0)
            {
                throw new Exception("Магазин пуст, вы не можете его разрядить");
            }
            return countCartridges.Pop();
        }
    }
}
