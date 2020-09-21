using UnityEngine;

namespace Assets.Scripts.Gameplay.LevelManagement
{
    [CreateAssetMenu(fileName = "LevelLayout", menuName = "Level/New")]
    public class LevelLayout : ScriptableObject
    {
        [SerializeField]
        public ObjectToSpawn[] ObjectsToSpawn;
    }
}
