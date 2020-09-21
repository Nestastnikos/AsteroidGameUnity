using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Gameplay.LevelManagement
{
    [Serializable]
    public class ObjectToSpawn
    {
        public GameObject Prefab;
        public int CountOfSpawns;
    }
}
