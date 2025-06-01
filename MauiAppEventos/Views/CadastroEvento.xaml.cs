using MauiAppEventos.Models;
using System.Globalization;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    App PropriedadesApp;

    public CadastroEvento()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_local.ItemsSource = PropriedadesApp.lista_locais;

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year + 2, DateTime.Now.Month, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(12);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(ent_nome.Text))
            {
                await DisplayAlert("Erro", "Por favor, informe o nome do evento.", "OK");
                return;
            }

            if (pck_local.SelectedItem == null)
            {
                await DisplayAlert("Erro", "Por favor, selecione o local do evento.", "OK");
                return;
            }

            if (string.IsNullOrEmpty(ent_custo.Text))
            {
                await DisplayAlert("Erro", "Por favor, informe o custo por participante.", "OK");
                return;
            }

            if (!double.TryParse(ent_custo.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double custo))
            {
                await DisplayAlert("Erro", "Por favor, informe um valor válido para o custo.", "OK");
                return;
            }

            if (dtpck_termino.Date <= dtpck_inicio.Date)
            {
                await DisplayAlert("Erro", "A data de término deve ser posterior à data de início.", "OK");
                return;
            }

            Evento evento = new Evento
            {
                Nome = ent_nome.Text,
                NumeroParticipantes = Convert.ToInt32(stp_participantes.Value),
                Local = pck_local.SelectedItem.ToString(),
                CustoPorParticipante = custo,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
            };

            await Navigation.PushAsync(new EventoCadastrado()
            {
                BindingContext = evento
            });

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_termino.MaximumDate = data_selecionada_inicio.AddMonths(12);
    }
}