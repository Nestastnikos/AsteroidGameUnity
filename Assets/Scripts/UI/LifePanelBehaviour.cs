using Assets.Scripts.Core.Spaceship;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class LifePanelBehaviour
    {
        private Stack<GameObject> _lives;

        public LifePanelBehaviour(GameObject panel, GameObject lifePrefab, int numLives)
        {
            _lives = new Stack<GameObject>();

            FillPanelWithLifePrefabs(panel, lifePrefab, numLives);
            SpaceshipView.OnDestroyed += LifeDown;
        }

        private void FillPanelWithLifePrefabs(GameObject panel, GameObject lifePrefab, int numLives)
        {
            for (int i = 0; i < numLives; i++)
            {
                var newLife = Object.Instantiate(lifePrefab);
                newLife.transform.SetParent(panel.transform, false);
                _lives.Push(newLife);

            }
        }

        void LifeDown()
        {
            if(_lives.Count == 0)
            {
                throw new System.Exception("LifePanelBehaviour.LifeDown(): LifeDown called on object with no lives");
            }

            var life = _lives.Pop();
            Object.Destroy(life.gameObject);
        }
    }
}
