﻿using Assets.Scripts.Core.Spaceship;

namespace Assets.Scripts.Core.General
{
    public interface IMovingRestrictedAdapter : IMovingAdapter
    {
        Spaceship.Spaceship State { get; }
    }
}
