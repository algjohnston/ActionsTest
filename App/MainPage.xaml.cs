namespace App;

using BusinessLogic;

public partial class MainPage : ContentPage
{

	readonly CounterService counterService = new();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		var (count, message) = counterService.Increment();
		CounterBtn.Text = message;
		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
