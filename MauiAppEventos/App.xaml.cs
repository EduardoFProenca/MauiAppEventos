using MauiAppEventos.Models;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public List<string> lista_locais = new List<string>
        {
            "Centro de Convenções São Paulo",
            "Hotel Grand Hyatt",
            "Auditório Ibirapuera",
            "Centro Cultural Banco do Brasil",
            "Espaço de Eventos Villa Lobos",
            "Teatro Municipal",
            "Centro de Eventos Rebouças",
            "Palácio das Convenções"
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}