namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private PoliceContext context;

        public Form1()
        {
            InitializeComponent();
            context = new PoliceContext();
            LoadData("Policemen");
            ToggleInputFields("Policemen");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
