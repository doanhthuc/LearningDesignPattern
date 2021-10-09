namespace Composite
{
    interface IComponent
    {
        void Play();
        void SetPlaySpeed(float speed);
        string GetName();
    }
}