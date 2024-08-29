using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class ListaPedidos : ContentPage
    {
        public ListaPedidos()
        {
            InitializeComponent();
        }

        
        private void OnCadastrarClicked(object sender, EventArgs e)
        {
           if (Application.Current != null)
    	Application.Current.MainPage = new CadastroPedido();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
        if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
        }
    }
}
