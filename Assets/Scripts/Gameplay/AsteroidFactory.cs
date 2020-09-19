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
        var spawnPosition = PositionGenerator.GeneratePositionInsideCameraView();
        var gameObject = Object.Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
        gameObject = SetRandomVelocityFor(gameObject);
        return gameObject;
    }

    private GameObject SetRandomVelocityFor(GameObject gameObject)
    {
        var x_speed = Random.Range(-3, 3);
        var y_speed = Random.Range(-3, 3);

        var rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(x_speed, y_speed);
        return gameObject;
    }

}
