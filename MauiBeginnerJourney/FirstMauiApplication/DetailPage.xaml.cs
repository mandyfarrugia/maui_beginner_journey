using FirstMauiApplication.ViewModels;

namespace FirstMauiApplication;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel detailViewModel)
	{
		InitializeComponent();
		BindingContext = detailViewModel;
	}
}