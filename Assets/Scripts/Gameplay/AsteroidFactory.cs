using Assets.Scripts.Utility;
using UnityEngine;
namespace Assets.Scripts.Gameplay
{
    public class AsteroidFactory
    {
        private GameObject asteroidPrefab;

        public AsteroidFactory(GameObject go)
        {
            asteroidPrefab = go;
        }

        public GameObject Spawn()
        {
            var spawnPosition = PositionGenerator.GeneratePositionInsideCameraView();
            var gameObject = Object.Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
            return gameObject;
        }
    }
}
