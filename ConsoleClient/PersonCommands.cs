using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Logic.Domain.PersonManagement;
using Workflows;

namespace RV24.PMA.UI.ConsoleClient;

class PersonCommands
{
    private readonly PersonManager _manager;
    private readonly PersonWorkflows _personWorkflows;

    public PersonCommands()
    {
        _manager = new PersonManager();
        _personWorkflows = new PersonWorkflows();
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