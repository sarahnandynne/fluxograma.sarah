using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class SelecioneFuncionario : ContentPage
    {
        public SelecioneFuncionario()
        {
            InitializeComponent();
        }
        void OnCadastroFuncionarioClicked (object sender, EventArgs e)
	    {
 		if (Application.Current != null)
    	Application.Current.MainPage = new CadastroFuncionario();
	    }

	    void OnListaFuncionarioClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new Lista();
	    }
        void OnVoltarFuncionarioClicked (object sender, EventArgs e)
	    {
		if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
	    }
    }
}