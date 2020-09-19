using UnityEngine;

namespace Assets.Scripts.Core
{
    public class OnSpaceshipBecomingInvisible : MonoBehaviour
    {
        private void OnBecameInvisible()
        {
            var old_x = transform.parent.position.x;
            var old_y = transform.parent.position.y;
            transform.parent.position = new Vector2(-old_x, -old_y);
            Debug.Log($"{old_x} {old_y}");
        }
    }
}
