using Assets.Scripts.Core.Spaceship;
using UnityEngine;

namespace Assets.Scripts.Core
{
    public class Models : MonoBehaviour
    {
        public SpaceshipModel Spaceship;

        private void Awake()
        {
            Spaceship = new SpaceshipModel();
        }
    }
}
