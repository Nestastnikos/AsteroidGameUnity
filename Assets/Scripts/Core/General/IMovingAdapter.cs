using UnityEngine;

namespace Assets.Scripts.Core.General
{
    public interface IMovingAdapter
    {
        Rigidbody2D MovingBody { get; }
    }
}
