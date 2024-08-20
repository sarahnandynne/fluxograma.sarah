using System;
using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class CadastroVendas : ContentPage
    {
        public CadastroVendas()
        {
            InitializeComponent();
        }

        private void OnFinalizarClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar o cadastro
            DisplayAlert("VENDA", "Venda confirmada com sucesso!", "OK");
        }


        private void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}