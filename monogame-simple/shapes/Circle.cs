using System.Numerics;

namespace shapes;

public class Circle {
    private Vector2 centre;
    private double radius;

    public Circle(Vector2 centre, double radius) {
        this.centre = centre;
        this.radius = radius;
    }

    public Vector2 GetCentre() { return centre; }
    public double GetRadius() { return radius; }
    public void SetCentre(Vector2 newCentre) { centre = newCentre; }
}