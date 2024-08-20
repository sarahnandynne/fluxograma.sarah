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
    	Application.Current.MainPage = new CadastroTransportadora();
	    }

	    void OnListaTransportadoraClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new Lista();
	    }
        void OnVoltarTransportadoraClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }

    }
}
