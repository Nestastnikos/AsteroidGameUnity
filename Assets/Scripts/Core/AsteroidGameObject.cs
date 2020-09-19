﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Debug.Log($"{old_x} {old_y}");
        }
    }
}