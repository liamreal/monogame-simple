namespace ecs;

public class Entity
{
    private int id;
    private Tag tag;

    public Entity(int id, Tag tag)
    {
        this.id = id;
        this.tag = tag;
    }

    public int GetId() { return id; }
    public Tag GetTag() { return tag; }
}