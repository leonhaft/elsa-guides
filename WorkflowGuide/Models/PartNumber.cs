
public class PartNumber
{
    public int Id { get; set; }

    public Category Category { get; set; }

    public string Description { get; set; }

    public string ProjectName { get; set; }

    public string? Remark { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public PartNumber(string projectName, Category category, string description, string? remark = null)
    {
        this.ProjectName = projectName;
        this.Category = category;
        this.Description = description;
        this.Remark = remark;
    }

    public PartNumber()
    {

    }
}
