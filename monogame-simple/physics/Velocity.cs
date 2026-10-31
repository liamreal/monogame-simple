using System.Numerics;
using ecs;

namespace physics;

public class Velocity : Component
{
    private double speed;

    public Velocity(double speed)
    {
        this.speed = speed;
    }

    public double GetPosition() { return this.speed; }
    public void SetPosition(double newSpeed) { this.speed = newSpeed; }
}