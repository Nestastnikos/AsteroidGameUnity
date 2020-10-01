using Assets.Scripts.Utility;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts.Gameplay.LevelManagement
{
    public class LevelSpawner : MonoBehaviour
    {
        public LevelLayout levelLayout;

        public void SpawnLevel()
        {
            foreach(ObjectToSpawn objectToSpawn in levelLayout.ObjectsToSpawn)
            {
                SpawnObjectOfGivenType(objectToSpawn);
            }
        }

        private void SpawnObjectOfGivenType(ObjectToSpawn toSpawn)
        {
            for (int i = 0; i < toSpawn.CountOfSpawns; i++)
            {
                var spawnPosition = GetFreeSpawnPositionFor(toSpawn.Prefab);
                Instantiate(toSpawn.Prefab, spawnPosition, Quaternion.identity);
            }
        }

        private Vector2 GetFreeSpawnPositionFor(GameObject prefab)
        {
            while(true)
            {
                var spawnPosition = PositionGenerator.GeneratePositionInsideCameraView();
                if(IsFreePosition(spawnPosition, prefab))
                {
                    return spawnPosition;
                }
            }
        }

        private bool IsFreePosition(Vector2 position, GameObject prefab)
        {
            var collider = prefab.GetComponent<Collider2D>();
            var size = collider.bounds.size;
            var result = Physics2D.OverlapBox(position, size, 0);
            return result == null;
            
        }

        private void Start()
        {
            Assert.IsNotNull(levelLayout);
            SpawnLevel();
        }
    }
}
