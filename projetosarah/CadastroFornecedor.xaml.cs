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
            // Handle Confirmar button click
            DisplayAlert("Confirmar", "Cadastro confirmado!", "OK");
        }

        private void OnAtualizarButtonClicked(object sender, EventArgs e)
        {
            // Handle Atualizar button click
            DisplayAlert("Atualizar", "Cadastro atualizado!", "OK");
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Handle Voltar button click
            Navigation.PopAsync();
        }
    }
}
