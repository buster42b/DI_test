using System;

namespace PlayerSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = Player.Instance; // Получаем экземпляр класса Player

            // Инициализируем игрока
            player.Health = 100;
            player.Lives = 3;
            player.Nickname = "John";
            player.Skills = new string[] { "Skill1", "Skill2", "Skill3" };
            player.Equipment = new Equipment();

            Console.WriteLine("Здоровье игрока: " + player.Health);
            Console.WriteLine("Никнейм игрока: " + player.Nickname);

            Equipment equipment = player.Equipment;
            equipment.AddItem(new Weapon("Винтовка", 50));
            equipment.AddItem(new Parachute());
            equipment.AddItem(new RocketPack(3));

            Console.ReadKey();
        }
    }
}
