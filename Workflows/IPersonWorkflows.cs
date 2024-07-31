using RV24.PMA.CrossCutting.DataClasses;

namespace Workflows;

public interface IPersonWorkflows
{
    void RunAdd(Person person);
}