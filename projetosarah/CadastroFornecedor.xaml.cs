using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
            ConfirmarButton.Clicked += OnConfirmarButtonClicked;
            AtualizarButton.Clicked += OnAtualizarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private void OnConfirmarButtonClicked(object sender, EventArgs e)
        {
            framecadastradosucesso.IsVisible=true;
            DisplayAlert("Confirmar", "Cadastro confirmado!", "OK");
        }

        private void OnAtualizarButtonClicked(object sender, EventArgs e)
        {
            frameatualizadosucesso.IsVisible=true;
            DisplayAlert("Atualizar", "Cadastro atualizado!", "OK");
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
            Navigation.PopAsync();
        }
    }
}
