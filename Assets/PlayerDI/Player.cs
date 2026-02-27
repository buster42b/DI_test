namespace PlayerDI
{
    public class Player : IPlayer
    {
        public int Health { get; set; }
        public int Lives { get; set; }
        public string Nickname { get; set; }
        public string[] Skills { get; set; }

        public IEquipment Equipment { get; private set; }
        
        public void Initialize(string nickname, string[] skills)
        {
            Nickname = nickname;
            Skills = skills;
        }

        public Player(
            IEquipment equipment,
            int startHealth,
            int startLives)
        {
            Equipment = equipment;
            Health = startHealth;
            Lives = startLives;
        }
    }
}