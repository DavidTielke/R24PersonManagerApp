namespace EmailManagement
{
    public class EmailSender : IEmailSender
    {
        public void Send(string message)
        {
            Console.WriteLine("Email gesendet: "+message);
        }
    }
}
