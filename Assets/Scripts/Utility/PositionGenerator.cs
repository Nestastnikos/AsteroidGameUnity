using UnityEngine;

namespace Assets.Scripts.Utility
{
    public class PositionGenerator
    {
        public static Vector2 GeneratePositionInsideCameraView()
        {
            var x = Random.Range(0.05f, 0.95f);
            var y = Random.Range(0.05f, 0.95f);
            var worldPosition = Camera.main.ViewportToWorldPoint(new Vector2(x, y));
            return worldPosition;
        }
    }
}
