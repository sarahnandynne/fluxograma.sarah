using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
            SearchButton.Clicked += OnSearchButtonClicked;
            EditButton.Clicked += OnEditButtonClicked;
            DeleteButton.Clicked += OnDeleteButtonClicked;
            CadastrarButton.Clicked += OnCadastrarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private void OnSearchButtonClicked(object sender, EventArgs e)
        {
            // Handle search logic
            DisplayAlert("Lista", $"Procurando por: {SearchEntry.Text}", "OK");
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            // Handle edit logic
            DisplayAlert("Atualizar cadastro", "SN Embalagens", "OK");
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Handle delete logic
            DisplayAlert("Tem certeza que deseja excluir?", "SN Embalagens", "OK");
        }

        private void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
             if (Application.Current != null)
    	Application.Current.MainPage = new CadastroCliente();
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
    	Application.Current.MainPage = new MainPage();
        }
    }
}
