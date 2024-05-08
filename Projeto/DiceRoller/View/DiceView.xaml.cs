using DiceRoller.Models;
namespace DiceRoller.View;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
	}

	private void RollBtn_Clicked(object sender, EventArgs e)
	{
		int quantidadeLados = Convert.ToInt32(Picker_Lados.SelectedItem);

        Dice dice = new Dice(quantidadeLados);
		dice.Rolar();
        Numero.Text = dice.NumeroSorteado.ToString();
	}
}	