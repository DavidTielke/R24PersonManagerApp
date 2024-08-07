namespace RV24.PMA.CrossCutting.DataClasses;

public class EntityBase
{
    public int Id { get; set; }
}

public interface ITechnicalData
{
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string UpdatedBy { get; set; }
}