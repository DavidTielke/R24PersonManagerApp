using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Logic.Business.Workflows.Contract;

public interface IPersonWorkflows
{
    void RunAdd(Person person);
}