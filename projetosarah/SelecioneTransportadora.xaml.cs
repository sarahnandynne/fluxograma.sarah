using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneTransportadora : ContentPage
    {
        public SelecioneTransportadora()
        {
            InitializeComponent();
        }
         void OnCadastroClientesClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroCliente();
	    }

	    void OnListaClientesClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new ListaClientes();
	    }
        void OnVoltarClienteClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }

    }
}
