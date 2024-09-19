using AtmLibrary;

namespace WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var bankInitializer = new BankInitializer();
            var accounts = bankInitializer.InitializeBank();
            var atm = bankInitializer.atm;

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(accounts, atm));
        }
    }
}