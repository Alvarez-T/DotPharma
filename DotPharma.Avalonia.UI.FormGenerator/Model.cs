namespace DotPharma.Avalonia.UI.FormGenerator;

public class Model
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }
    public DateTime DateRegistered { get; set; }
    public List<Child> Children { get; set; }

}

public class Child
{
    public string Name { get; set; }
}