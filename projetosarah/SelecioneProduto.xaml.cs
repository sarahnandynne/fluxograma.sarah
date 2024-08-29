using Microsoft.Maui.Controls;

namespace projetosarah
{
	public partial class SelecioneProduto : ContentPage
	{
		public SelecioneProduto()
		{
			InitializeComponent();
		}
		void OnCadastroProdutosClicked(object sender, EventArgs e)
		{
			if (Application.Current != null)
				Application.Current.MainPage = new CadastroProduto();
		}

		void OnListaProdutosClicked1(object sender, EventArgs e)
		{
			if (Application.Current != null)
				Application.Current.MainPage = new EstoqueProduto();
		}
		void OnVoltarProdutosClicked(object sender, EventArgs e)
		{
			if (Application.Current != null)
				Application.Current.MainPage = new MainPage();
		}
	}
}