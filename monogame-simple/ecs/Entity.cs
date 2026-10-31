namespace ecs;

public class Entity
{
    private int id;

    public Entity(int id)
    {
        this.id = id;
    }

    public int GetId() { return this.id; }
}