using System;
using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class EstoqueProduto : ContentPage
    {
        public EstoqueProduto()
        {
            InitializeComponent();
        }

        private void OnCadastrarNovosClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastroProduto();
        }


        private void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}