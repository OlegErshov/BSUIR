using MauiApp1.Entites;
using MauiApp1.Services;
using System.Collections.ObjectModel;

namespace MauiApp1.Pages;

public partial class Lab3 : ContentPage
{
    private readonly SQLiteService _dbService;

    public ObservableCollection<Hero> Heroes { get; set; }
    public ObservableCollection<SuperPower> SuperPoweres { get; set; }
    
    public Lab3(IDbService dbService)
    {
        InitializeComponent();
        _dbService = dbService as SQLiteService;
        _dbService.Init();
        Heroes = new ObservableCollection<Hero>(_dbService.GetAllHeroes());
        BindingContext = this;
        
    }

    public Lab3()
    {

        InitializeComponent();
    }

   

    private void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        SuperPoweres = new ObservableCollection<SuperPower>(_dbService.GetHeroSuperPowers((picker.SelectedItem as Hero).ID));
        PowerListView.ItemsSource = SuperPoweres;
    }
}

























