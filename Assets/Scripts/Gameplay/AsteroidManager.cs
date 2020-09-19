using Assets.Scripts.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class AsteroidManager : MonoBehaviour
    {
        public GameObject AsteroidPrefab;

        private AsteroidFactory asteroidFactory;

        private void Awake()
        {
            asteroidFactory = new AsteroidFactory(AsteroidPrefab);
        }

        void Start()
        {
            asteroidFactory.Spawn();
            asteroidFactory.Spawn();
            asteroidFactory.Spawn();
        }
    }
}
