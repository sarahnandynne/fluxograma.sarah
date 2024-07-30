using Microsoft.Maui.Controls;

namespace projetosarah;

    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
           framecadastrosucesso.IsVisible=true;
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            frameatualizadosucesso.IsVisible=true;
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
           if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
        }
    }

