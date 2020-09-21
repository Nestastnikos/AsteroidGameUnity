using Assets.Scripts.Core.Spaceship;

namespace Assets.Scripts.Core.General
{
    public interface IMovingRestrictedAdapter : IMovingAdapter
    {
        SpaceshipState State { get; }
    }
}
