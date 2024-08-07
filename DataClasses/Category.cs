namespace RV24.PMA.CrossCutting.DataClasses;

public class Category : EntityBase
{
    public string Name { get; set; }
    public virtual ICollection<Person> Persons { get; set; }
}