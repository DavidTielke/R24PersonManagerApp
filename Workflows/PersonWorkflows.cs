using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailManagement;
using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Logic.Domain.PersonManagement;

namespace Workflows
{
    public class PersonWorkflows
    {
        private readonly PersonManager _personManager;
        private readonly EmailSender _emailSender;

        public PersonWorkflows()
        {
            _personManager = new PersonManager();
            _emailSender = new EmailSender();
        }

        public void Add(Person person)
        {
            _personManager.Add(person);
            _emailSender.Send($"Begrüssungsmail für {person.Name}");
        }
    }
}
