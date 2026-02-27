namespace PlayerDI
{
    public class Weapon : Item
    {
        public int Ammo { get; private set; }

        public Weapon(int ammo) : base("Rifle")
        {
            Ammo = ammo;
        }
    }
}