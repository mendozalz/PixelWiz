using PixelWiz.Models;
using System.Collections.ObjectModel;

namespace PixelWiz.Views;

public partial class DashBoardView : ContentPage
{
	public ObservableCollection<Profiles> Profiles { get; set; }
	public ObservableCollection<GeneratedImages> GeneratedImages { get; set; }
    public DashBoardView()
	{
		InitializeComponent();
		LoadData();
	}

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profiles> {
    new Profiles
    {
        ProfileName = "Lenin",
        ProfileImg =  "dot_net.svg",
        NoPhotos = 12
    },
    new Profiles
    {
        ProfileName = "Che",
        ProfileImg = "maria_profile.jpg",
        NoPhotos = 25
    },
    new Profiles
    {
        ProfileName = "Mia",
        ProfileImg = "carlos_avatar.png",
        NoPhotos = 8
    },
    new Profiles
    {
        ProfileName = "Ayleen",
        ProfileImg = "sofia_pic.jpg",
        NoPhotos = 18
    },
    new Profiles
    {
        ProfileName = "Edward",
        ProfileImg = "diego_selfie.png",
        NoPhotos = 30
    }
};

        GeneratedImages = new ObservableCollection<GeneratedImages> {
    new GeneratedImages
    {
        ImagePath = "dot_net.svg",
        MainKeyword =  "Robot",
        Keyword = new List<string> {
            "AI, robotic, human, metal"
        }
    },
    new GeneratedImages
    {
        ImagePath = "nature_scene.jpg",
        MainKeyword = "Landscape",
        Keyword = new List<string> {
            "mountains, forest, river, sunset"
        }
    },
    new GeneratedImages
    {
        ImagePath = "space_exploration.png",
        MainKeyword = "Cosmos",
        Keyword = new List<string> {
            "planets, stars, galaxy, astronaut"
        }
    },
    new GeneratedImages
    {
        ImagePath = "futuristic_city.jpg",
        MainKeyword = "Metropolis",
        Keyword = new List<string> {
            "skyscrapers, flying cars, neon, hologram"
        }
    },
    new GeneratedImages
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