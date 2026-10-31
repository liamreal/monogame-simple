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
        shape.SetCentre(newPosition);
    }
    public double GetLength() { return shape.GetRadius(); }
    public Vector2 GetPosition() { return shape.GetCentre(); }
}