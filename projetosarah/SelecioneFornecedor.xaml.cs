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
    	Application.Current.MainPage = new CadastroFornecedor();
	    }

	    void OnListaFornecedorClicked (object sender, EventArgs e)
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