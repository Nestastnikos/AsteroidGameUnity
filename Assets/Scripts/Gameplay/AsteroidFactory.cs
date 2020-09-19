using Assets.Scripts.Utility;
using UnityEngine;

public class AsteroidFactory
{
    private GameObject asteroidPrefab;

    public AsteroidFactory(GameObject go)
    {
        asteroidPrefab = go;
    }


    public GameObject Spawn()
    {
        Vector2 spawnPosition = PositionGenerator.GeneratePositionInsideCameraView();
        return Object.Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }

}
