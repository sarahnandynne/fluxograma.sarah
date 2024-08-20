using System;
using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar o cadastro
            DisplayAlert("CONFIRMAR", "Cadastro confirmado com sucesso!", "OK");
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar o cadastro
            DisplayAlert("ATUALIZAR", "Cadastro atualizado com sucesso!", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}