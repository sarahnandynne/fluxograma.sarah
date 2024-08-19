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
            // Lógica para confirmar o cadastro
            DisplayAlert("Confirmar", "Cadastro confirmado com sucesso!", "OK");
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar o cadastro
            DisplayAlert("Atualizar", "Cadastro atualizado com sucesso!", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
        }
    }
}
