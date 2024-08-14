using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecionePedido : ContentPage
{        public SelecionePedido()
        {
            InitializeComponent();
        }
        void OnCadastroPedidosClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroFornecedor();
	    }

	    void OnListaPedidosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new ListaFornecedor();
	    }
        void OnVoltarPedidosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
}
}
