using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneCliente : ContentPage
{        public SelecioneCliente()
        {
            InitializeComponent();
        }
        void OnCadastroClientesClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroFornecedor();
	    }

	    void OnListaClientesClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new ListaFornecedor();
	    }
        void OnVoltarClienteClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
}
}
