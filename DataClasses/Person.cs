namespace RV24.PMA.CrossCutting.DataClasses;

public class Person : EntityBase
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Category Category { get; set; }
    public int FK_CategoryId { get; set; }
}