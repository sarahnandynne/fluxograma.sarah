using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneProduto : ContentPage
{        public SelecioneProduto()
        {
            InitializeComponent();
        }
        void OnCadastroProdutosClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroFornecedor();
	    }

	    void OnListaProdutosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new ListaFornecedor();
	    }
        void OnVoltarProdutosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
}
}