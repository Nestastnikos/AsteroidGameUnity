using Assets.Scripts.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Spaceship
{
    public class PlayerRespawnAfterDeath : IRespawner
    {
        public CircleCollider2D colliderRef { get; }
        public SpriteRenderer rendererRef { get; }
        public GameObject gameObject { get; }

        public PlayerRespawnAfterDeath(CircleCollider2D colliderRef,
                                        SpriteRenderer rendererRef,
                                        GameObject gameObject)
        {
            this.colliderRef = colliderRef;
            this.rendererRef = rendererRef;
            this.gameObject = gameObject;
        }

        public IEnumerator Respawn()
        {
            gameObject.transform.position = PositionGenerator.GeneratePositionInsideCameraView();
            SetAlphaChannelValueOfSpriteTo(0.5f);

            gameObject.SetActive(true);
            yield return new WaitForSeconds(3.0f);

            MakeThePlayerCollidableAgain();
        }

        private void SetAlphaChannelValueOfSpriteTo(float value)
        {
            var new_color = rendererRef.color;
            new_color.a = value;
            rendererRef.color = new_color;
        }

        private void MakeThePlayerCollidableAgain()
        {
            colliderRef.enabled = true;

            SetAlphaChannelValueOfSpriteTo(1.0f);
        }
    }
}
