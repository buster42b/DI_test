public class Player
{
    private static Player _instance;
    public int Health { get; set; }
    public int Lives { get; set; }
    public string Nickname { get; set; }

    public string[] Skills { get; set; }
                
    public Equipment Equipment { get; set; }

    public Player()
    {
        _instance = this;
    }

    public static Player Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Player();
            }
            return _instance;
        }
    }
}