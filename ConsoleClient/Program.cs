namespace RV24.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commands = new PersonCommands();

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
