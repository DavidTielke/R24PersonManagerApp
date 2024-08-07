using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Logic.Business.Workflows.Contract;
using RV24.PMA.Logic.Domain.EmailManagement.Contract;
using RV24.PMA.Logic.Domain.PersonManagement.Contract;

namespace RV24.PMA.Logic.Business.Workflows
{
    public class PersonWorkflows : IPersonWorkflows
    {
        private readonly IPersonManager _personManager;
        private readonly IEmailSender _emailSender;

        public PersonWorkflows(IPersonManager personManager, IEmailSender emailSender)
        {
            _personManager = personManager;
            _emailSender = emailSender;
        }

        public void RunAdd(Person person)
        {
            _personManager.Add(person);
            _emailSender.Send($"Begrüssungsmail für {person.Name}");
        }
    }
}
