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
        ProfileImg =  "avatar_1.jpg",
        NoPhotos = 12
    },
    new Profile
    {
        ProfileName = "Edward",
        ProfileImg = "avatar_2.jpg",
        NoPhotos = 25
    },
    new Profile
    {
        ProfileName = "Camil",
        ProfileImg = "avatar_3.jpg",
        NoPhotos = 8
    },
    new Profile
    {
        ProfileName = "Che",
        ProfileImg = "avatar_4.jpg",
        NoPhotos = 18
    },
    new Profile
    {
        ProfileName = "Mia",
        ProfileImg = "avatar_5.jpg",
        NoPhotos = 30
    }
};

        GeneratedImages = new ObservableCollection<GeneratedImage> {
    new GeneratedImage
    {
        ImagePath = "img_5.jpeg",
        MainKeyword =  "Robot",
        Keyword = new List<string> {
            "AI, robotic, human, metal"
        }
    },
    new GeneratedImage
    {
        ImagePath = "img_1.jpeg",
        MainKeyword = "Landscape",
        Keyword = new List<string> {
            "mountains, forest, river, sunset"
        }
    },
    new GeneratedImage
    {
        ImagePath = "img_2.jpeg",
        MainKeyword = "Cosmos",
        Keyword = new List<string> {
            "planets, stars, galaxy, astronaut"
        }
    },
    new GeneratedImage
    {
        ImagePath = "img_3.jpeg",
        MainKeyword = "Metropolis",
        Keyword = new List<string> {
            "skyscrapers, flying cars, neon, hologram"
        }
    },
    new GeneratedImage
    {
        ImagePath = "img_4.jpeg",
        MainKeyword = "Ocean",
        Keyword = new List<string> {
            "fish, coral, submarine, bioluminescence"
        }
    }
};

    }
}