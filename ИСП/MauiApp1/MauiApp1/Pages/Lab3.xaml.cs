using MauiApp1.Services;

namespace MauiApp1.Pages;

public partial class Lab3 : ContentPage
{
    public SQLiteService inter;
    Picker HeroPicker = new Picker { Title = "Герой" };
    Picker PowerPicker = new Picker { Title = "Сила" };
    public Lab3(SQLiteService serv)
	{
        inter = serv;
        inter.Init();

      
        
        foreach(var item in inter.GetAllHeroes())
        {
            HeroPicker.Items.Add(item.Name);

            foreach(var power in inter.GetHeroSuperPowers(item.ID)) {

                PowerPicker.Items.Add(power.Name);
            }
        }

        InitializeComponent();

    
    }
}