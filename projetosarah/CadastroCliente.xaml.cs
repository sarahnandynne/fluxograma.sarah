using System;
using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Código para ação de confirmar
            DisplayAlert("Confirmar", "Dados confirmados", "OK");
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            // Código para ação de atualizar
            DisplayAlert("Atualizar", "Dados atualizados", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Código para ação de voltar
            Navigation.PopAsync();
        }
    }
}
