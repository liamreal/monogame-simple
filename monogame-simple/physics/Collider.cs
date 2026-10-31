using System.Numerics;
using ecs;
using shapes;

namespace physics;

public class Collider : Component
{
    private Circle shape;

    public Collider(Circle shape)
    {
        this.shape = shape;
    }


    public void SetPosition(Vector2 newPosition) {
        this.shape.SetCentre(newPosition);
    }
    public double GetLength() { return this.shape.GetRadius(); }
    public Vector2 GetPosition() { return this.shape.GetCentre(); }
}