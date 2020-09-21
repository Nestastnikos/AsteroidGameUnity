using UnityEngine;

namespace Assets.Scripts.Core
{
    abstract public class AsteroidGameObject : MonoBehaviour
    {
        protected void OnBecameInvisible()
        {
            var old_x = transform.position.x;
            var old_y = transform.position.y;
            transform.position = new Vector2(-old_x, -old_y);
        }
    }
}
