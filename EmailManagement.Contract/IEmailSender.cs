namespace RV24.PMA.Logic.Domain.EmailManagement.Contract;

public interface IEmailSender
{
    void Send(string message);
}