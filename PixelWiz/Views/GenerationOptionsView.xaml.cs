namespace PixelWiz.Views;

public partial class GenerationOptionsView : ContentPage
{
	public List<string> Options { get; set; }
	public GenerationOptionsView()
	{
		InitializeComponent();
		FillOptions();
		BindingContext = this;
	}

	private void FillOptions()
	{
		Options = new List<string> 
		{
			"Mundo",
			"Invieron",
			"Arboles",
			"Paisajes",
			"Verano"
		};
	}
}