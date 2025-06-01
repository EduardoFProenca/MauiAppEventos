namespace MauiAppEventos.Views;

public partial class EventoCadastrado : ContentPage
{
    public EventoCadastrado()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Volta para a tela de cadastro
        await Navigation.PopAsync();
    }
}