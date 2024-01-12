using System;

namespace AK_47.Classes
{
    public class Gas
        //Газ, но тут очевидно
    {
        public bool IgnitionOfGunpowder { get; set; } //если порох воспламенился - истина, если нет - ложь
        public bool IngressOfGasesIntoTheGasChamber { get; set; } //если газы попали в газовую камору - истина, 
                                                                  //если нет - ложь
        public void IgnitionCheck()
        {
            if (this.IgnitionOfGunpowder)
                throw new InvalidOperationException();
            this.IgnitionOfGunpowder = true;
        }

        public void IngressCheck()
        {
            if (this.IngressOfGasesIntoTheGasChamber)
                throw new InvalidOperationException();
            this.IngressOfGasesIntoTheGasChamber = true;
        }
    }
}
