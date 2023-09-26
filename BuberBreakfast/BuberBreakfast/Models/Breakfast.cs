namespace BuberBreakfast.Models;
public class Breakfast
{
    public Breakfast(Guid id, string name, string description, DateTime startDateTime, DateTime endDateTime, DateTime lastModifiedDateTime, List<string> savory, List<string> sweet)
    {
        this.Id = id;
        this.Description = description;
        this.Name = name;
        this.StartDateTime = startDateTime;
        this.EndDateTime = endDateTime;
        this.LastModifiedDateTime = lastModifiedDateTime;
        this.Savory = savory;
        this.Sweet = sweet;
    }

    // public Breakfast(Guid id, string description, string description1, DateTime startDateTime, DateTime endDateTime, DateTime lastModifiedDateTime, List<string> savory, List<string> sweet) : this(id, description, description1, startDateTime, endDateTime, lastModifiedDateTime, savory,sweet)
    // {
    // }

    public Guid Id { get; }
    public string Name { get; }

    public string Description { get; }

    public DateTime StartDateTime { get; }

    public DateTime EndDateTime { get; }

    public DateTime LastModifiedDateTime { get; }

    public List<string> Savory { get; }

    public List<string> Sweet { get; }
}
