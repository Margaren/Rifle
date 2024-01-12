using System;

namespace AK_47.Classes
{
    class Shooting
    {
        static void Main()
        {
            bool isError = false;
            var magazine = new Magazine();
            var rifle = new Rifle();
            var cartridge = new Cartridge(30);
            while (!isError)
            {
                try
                {
                    rifle.Attach(magazine);
                    magazine.Load(cartridge);
                    rifle.RemoveFuse();
                    rifle.Recharge();
                    rifle.Shoot();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isError = true;
                }
            }
        }
    }
}
