namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly PolicemanDao policemanDao;
        private readonly OffenderDao offenderDao;
        public Form1()
        {
            InitializeComponent();
            var context = new PoliceContext();
            policemanDao = new PolicemanDao(context);
            offenderDao = new OffenderDao(context);
            LoadData("Policemen");
            ToggleInputFields("Policemen");
        }
    }
}
