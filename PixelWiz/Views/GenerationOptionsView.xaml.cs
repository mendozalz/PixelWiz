using PixelWiz.Models;

namespace PixelWiz.Views;

public partial class GenerationOptionsView : ContentPage
{
	public List<string> Options { get; set; }
	public List<ArtStyle> Styles { get; set; }
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

		Styles = new List<ArtStyle>(){
			new ArtStyle() { Name= "Anime", ImgUrl="anime.jpg"},
			new ArtStyle() { Name= "Arte", ImgUrl="arte.jpg"},
			new ArtStyle() { Name= "Real", ImgUrl="real.jpg"},
			new ArtStyle() { Name= "PopArt", ImgUrl="popart.jpg"},
			new ArtStyle() { Name= "Subreal", ImgUrl="subreal.jpg"},
		};
	}
}