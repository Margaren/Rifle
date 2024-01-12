using System;

namespace AK_47.Classes
{
    //Газовый поршень
    public class GasPiston
    {
        public bool PistonRepulsion { get; set; } //если газовый поршень оттолкнулся - истина, если нет - ложь
        public void Repulsion()
        {
            if (this.PistonRepulsion)
                throw new InvalidOperationException();
            this.PistonRepulsion = true;
        }
    }
}
