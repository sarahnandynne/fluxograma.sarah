using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneMT : ContentPage
{        public SelecioneMT()
        {
            InitializeComponent();
        }
        void OnCadastroMTClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroCliente();
	    }

	    void OnListaMTClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new ListaClientes();
	    }
        void OnVoltarMTClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
}
}
