namespace PlayerDI
{
    public class RocketPack : Item
    {
        public int Charges { get; private set; }

        public RocketPack(int charges) : base("RocketPack")
        {
            Charges = charges;
        }
    }
}