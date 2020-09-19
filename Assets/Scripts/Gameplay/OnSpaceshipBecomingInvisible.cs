using UnityEngine;

namespace Assets.Scripts.Core
{
    public class OnSpaceshipBecomingInvisible : MonoBehaviour
    {
        // OnBecameInvisible sometimes does not trigger when the
        // spaceship leaves the screen and the player
        // just flies freely in the space, therefore we want to add some
        // magic fraction to "push" the player onto the screen to make
        // sure tha the player is visible and that the Event handler
        // will catch the player next time the spaceship leaves the screen
        private readonly int MAGIC_FRACTION = 10;

        private void OnBecameInvisible()
        {
            var new_x = GetHorizontallyFlippedPosition();
            var new_y = GetVerticallyFlippedPosition();
            transform.parent.position = new Vector2(new_x, new_y);
        }

        private float GetHorizontallyFlippedPosition()
        {
            return -transform.parent.position.x + GetFractionX();
        }

        private float GetVerticallyFlippedPosition()
        {
            return -transform.parent.position.y + GetFractionY();
        }

        private float GetFractionX()
        {
            return transform.parent.position.x/MAGIC_FRACTION;
        }

        private float GetFractionY()
        {
            return transform.parent.position.y / MAGIC_FRACTION;
        }
    }
}
