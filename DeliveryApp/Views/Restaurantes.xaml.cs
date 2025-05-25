using DeliveryApp.ViewModels;

namespace DeliveryApp.Views;

public partial class Restaurantes : ContentPage
{
	public Restaurantes()
	{
		InitializeComponent();
        // conectar com a view com a classe ViewModel
        // o BindingContext é a classe que vai fazer a comunicacao entre a view e o modelo de dados

        BindingContext = new RestaurantesViewModel();
    }
}