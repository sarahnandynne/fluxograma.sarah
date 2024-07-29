using Microsoft.Maui.Controls;

namespace projetosarah;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void OnClientesClicked (object sender, EventArgs e)
	{
 		if (Application.Current != null)
    	Application.Current.MainPage = new SelecioneCliente();
	}

	void OnPedidosClicked (object sender, EventArgs e)
	{
		if (Application.Current != null)
    	Application.Current.MainPage = new SelecionePedido();
	}
	void OnProdutosClicked (object sender, EventArgs e)
	{
		
		if (Application.Current != null)
    	Application.Current.MainPage = new SelecioneProduto();
	}
	void OnMateriaPrimaClicked (object sender, EventArgs e)
	{
		if (Application.Current != null)
    	Application.Current.MainPage = new SelecioneMT();
	}
	void OnFornecedoresClicked (object sender, EventArgs e)
	{
		
	}
	void OnFuncionarioClicked (object sender, EventArgs e)
	{
		
	}
	void OnTransportadoraClicked (object sender, EventArgs e)
	{
		
	}
}


