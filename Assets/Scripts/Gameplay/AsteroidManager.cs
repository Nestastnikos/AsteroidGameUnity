using Assets.Scripts.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class AsteroidManager : MonoBehaviour
    {
        public GameObject AsteroidPrefab;
        public int AsteroidsToSpawn;
        private AsteroidFactory asteroidFactory;

        private void Awake()
        {
            asteroidFactory = new AsteroidFactory(AsteroidPrefab);
        }

        void Start()
        {
            for (int i = 0; i < AsteroidsToSpawn; i++)
            {
                asteroidFactory.Spawn();
            }
        }
    }
}
