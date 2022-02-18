
public class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public Category(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    public Category(string name)
    {
        this.Name = name;
    }
    public Category(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}

