using System;

namespace AK_47.Classes
{
    //Пружина магазина
    public class MagazineSpring
    {
        public bool EjectedCartridge { get; set; } //вытолкнут - истина, не вытолкнут - ложь
        public void PushOutTheCartridge()
        {
            if (this.EjectedCartridge)
                throw new InvalidOperationException();
            this.EjectedCartridge = true;
        }
    }
}
