using System;

namespace AK_47.Classes
{
    //Патронник
    public class Chamber
    {
        public bool CartridgeInTheChamber { get; set; } //есть патрон в патроннике - истина, нет патрона - ложь
        

        public void CheckingTheCartridgeInTheChamber()
        {
            if (this.CartridgeInTheChamber)
                throw new InvalidOperationException();
            this.CartridgeInTheChamber = true;
        }


    }
}
