using System;

namespace AK_47.Classes
{
    //Патрон
    public class Cartridge
    {
        public bool Used { get; private set; }
        public int CountOfCartridges { get; }

        public void Use()
        {
            if (Used)
                throw new Exception("Патрон уже использован");
            Used = true;
        }
    }
}
