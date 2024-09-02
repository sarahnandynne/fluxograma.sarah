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
    	Application.Current.MainPage = new CadastroMateriaPrima();
	    }

	    void OnListaMTClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new EstoqueMT();
	    }
        void OnVoltarMTClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
}
}
