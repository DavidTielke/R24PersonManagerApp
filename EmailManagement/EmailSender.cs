using RV24.PMA.Logic.Domain.EmailManagement.Contract;

namespace RV24.PMA.Logic.Domain.EmailManagement
{
    public class EmailSender : IEmailSender
    {
        public void Send(string message)
        {
            Console.WriteLine("Email gesendet: "+message);
        }
    }
}
