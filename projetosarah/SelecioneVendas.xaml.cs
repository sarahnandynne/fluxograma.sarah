using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneVendas : ContentPage
{        public SelecioneVendas()
        {
            InitializeComponent();
        }
        void OnVendaProdutosClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroVendas();
	    }

	    void OnEstoqueProdutosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new EstoqueProduto();
	    }
        void OnVoltarProdutosClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
}
}
