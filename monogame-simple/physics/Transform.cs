using System.Numerics;
using ecs;

namespace physics;

public class Transform : Component
{
    private Vector2 position;

    public Transform(Vector2 position)
    {
        this.position = position;
    }

    public Vector2 GetPosition() { return this.position; }
    public void SetPosition(Vector2 newPosition) { this.position = newPosition; }
}