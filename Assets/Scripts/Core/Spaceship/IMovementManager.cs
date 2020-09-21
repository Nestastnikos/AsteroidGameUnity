namespace Assets.Scripts.Core.Spaceship
{
    public interface IMovementManager
    {
        void TryMoveForward();
        void TryTurnLeft();
        void TryTurnRight();
    }
}
