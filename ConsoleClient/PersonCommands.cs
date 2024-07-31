using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Logic.Domain.PersonManagement;
using Workflows;

namespace RV24.PMA.UI.ConsoleClient;

class PersonCommands : IPersonCommands
{
    private readonly IPersonManager _manager;
    private readonly IPersonWorkflows _personWorkflows;

    public PersonCommands(IPersonManager manager, IPersonWorkflows personWorkflows)
    {
        _manager = manager;
        _personWorkflows = personWorkflows;
    }

    public void DisplayAllAdults()
    {
        var adults = _manager.GetAllAdults().ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }

    public void DisplayAllChildren()
    {
        var children = _manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }

    public void AddTestPerson()
    {
        var person = new Person
        {
            Name = "Pferdi",
            Age = 3
        };
        _personWorkflows.Add(person);
    }
}