using SQLITEDemo.MVVM.ViewModels;

namespace SQLITEDemo.MVVM.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		  BindingContext = new MainPageViewModel();
	}
}