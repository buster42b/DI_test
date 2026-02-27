using Zenject;
using UnityEngine;

namespace PlayerDI
{
    public class GameController : MonoBehaviour
    {
        private IPlayer _player;
        private Weapon _weapon;
        private RocketPack _rocketPack;
        private Parachute _parachute;

        [Inject]
        public void Construct(
            IPlayer player,
            Weapon weapon,
            RocketPack rocketPack,
            Parachute parachute)
        {
            _player = player;
            _weapon = weapon;
            _rocketPack = rocketPack;
            _parachute = parachute;
        }

        void Start()
        {
            _player.Initialize("John", new[] {"Skill1", "Skill2", "Skill3"});

            _player.Equipment.AddItem(_weapon);
            _player.Equipment.AddItem(_parachute);
            _player.Equipment.AddItem(_rocketPack);
        }
    }
}