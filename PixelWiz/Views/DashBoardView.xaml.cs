using PixelWiz.Models;
using System.Collections.ObjectModel;

namespace PixelWiz.Views;

public partial class DashBoardView : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }
    public DashBoardView()
	{
		InitializeComponent();
		LoadData();
        BindingContext = this;
	}

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile> {
    new Profile
    {
        ProfileName = "Lenin",
        ProfileImg =  "dot_net.svg",
        NoPhotos = 12
    },
    new Profile
    {
        ProfileName = "Che",
        ProfileImg = "dot_net.svg",
        NoPhotos = 25
    },
    new Profile
    {
        ProfileName = "Mia",
        ProfileImg = "dot_net.svg",
        NoPhotos = 8
    },
    new Profile
    {
        ProfileName = "Ayleen",
        ProfileImg = "dot_net.svg",
        NoPhotos = 18
    },
    new Profile
    {
        ProfileName = "Edward",
        ProfileImg = "dot_net.svg",
        NoPhotos = 30
    }
};

        GeneratedImages = new ObservableCollection<GeneratedImage> {
    new GeneratedImage
    {
        ImagePath = "dot_net.svg",
        MainKeyword =  "Robot",
        Keyword = new List<string> {
            "AI, robotic, human, metal"
        }
    },
    new GeneratedImage
    {
        ImagePath = "nature_scene.jpg",
        MainKeyword = "Landscape",
        Keyword = new List<string> {
            "mountains, forest, river, sunset"
        }
    },
    new GeneratedImage
    {
        ImagePath = "space_exploration.png",
        MainKeyword = "Cosmos",
        Keyword = new List<string> {
            "planets, stars, galaxy, astronaut"
        }
    },
    new GeneratedImage
    {
        ImagePath = "futuristic_city.jpg",
        MainKeyword = "Metropolis",
        Keyword = new List<string> {
            "skyscrapers, flying cars, neon, hologram"
        }
    },
    new GeneratedImage
    {
        ImagePath = "underwater_world.png",
        MainKeyword = "Ocean",
        Keyword = new List<string> {
            "fish, coral, submarine, bioluminescence"
        }
    }
};

    }
}