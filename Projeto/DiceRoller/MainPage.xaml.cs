namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int lados = Convert.ToInt32(Picker_Lados.SelectedItem);

            Random random = new Random();

            int aleatorio = random.Next(1, lados + 1);

            Numero.Text = aleatorio.ToString();
        }
    }

}
