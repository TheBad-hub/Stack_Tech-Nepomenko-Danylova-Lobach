using AtmLibrary;


namespace WinForm
{
    public partial class NearestAtmsForm : Form
    {
        public NearestAtmsForm(List<AutomatedTellerMachine> nearestAtms, AutomatedTellerMachine currentAtm)
        {
            InitializeComponent();

            // Додавання банкоматів до ListBox з вказанням відстані
            foreach (var atm in nearestAtms)
            {
                double distance = currentAtm.CalculateDistance(atm);

                lstNearestAtms.Items.Add($"{atm.Name} - {atm.Latitude}, {atm.Longitude}; Distance: {distance:F2} km");
            }
        }
    }
}
