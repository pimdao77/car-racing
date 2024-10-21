using MauiAppCSharpBasic.Classes;

namespace MauiAppCSharpBasic;

public partial class MainPage : ContentPage
{
	Car Mercedes;
	Car Audi;
	bool isFinish=false;
	public MainPage()
	{
		InitializeComponent();

		Mercedes = new Car("cls220d amg", 220 ,20);
		Mercedes.UseFuelRate = 10;
		Audi = new Car("A5" , 180, 10);
		Audi.UseFuelRate = 8;

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(!this.isFinish)
		{
		 var ScreenWidth = Application.Current.MainPage.Width;
		 this.MercedesRun(ScreenWidth);
		 this.AudiRun(ScreenWidth);
		 this.mylabel.Text = Mercedes.ShowInfo() + "\n" + Audi.ShowInfo();
		 this.isFinish = true;
		 
		}
		else
		{
		ImageCar1.TranslateTo(0,0,0,Easing.Linear);
		ImageCar2.TranslateTo(0,0,0,Easing.Linear);
		this.isFinish = false;
		}
		//Mercedes.Run(10);
		//Audi.Run(5);
		//mylabel.Text = Mercedes.ShowInfo() +"\n" + Audi.ShowInfo();
    }
	private void MercedesRun (double distance)
	{
		var TimeUse = Mercedes.TimeUseForRun(distance);
		ImageCar1.TranslateTo(distance-100,0,TimeUse*1000,Easing.Linear);
	}
	private void AudiRun (double distance)
	{
		var TimeUse = Audi.TimeUseForRun(distance);
		ImageCar2.TranslateTo(distance-100,0,TimeUse*1000,Easing.Linear);
	}
}

