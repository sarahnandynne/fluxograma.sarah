using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneFornecedor : ContentPage
    {
        public SelecioneFornecedor()
        {
            InitializeComponent();
        }
        void OnCadastroFornecedorClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroFornecedorPage();
	    }

	    void OnListaFornecedorClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new Lista();
	    }
        void OnVoltarFornecedorClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
    }
}