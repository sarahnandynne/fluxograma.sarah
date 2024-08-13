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
    	Application.Current.MainPage = new CadastroCliente();
	    }

	    void OnListaPedidosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new ListaClientes();
	    }
        void OnVoltarPedidosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
}
}
