using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneTransportadora : ContentPage
    {
        public SelecioneTransportadora()
        {
            InitializeComponent();
        }
         void OnCadastroTransportadoraClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroFornecedor();
	    }

	    void OnListaTransportadoraClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new ListaFornecedor();
	    }
        void OnVoltarTransportadoraClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }

    }
}
