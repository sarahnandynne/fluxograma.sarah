using System;
using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class EstoqueMT : ContentPage
    {
        public EstoqueMT()
        {
            InitializeComponent();
        }

        private void OnCadastrarMTClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastroMateriaPrima();
        }


        private void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}