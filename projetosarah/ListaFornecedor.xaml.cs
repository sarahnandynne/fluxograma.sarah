using Microsoft.Maui.Controls;

namespace projetosarah
{
    public partial class ListaFornecedor : ContentPage
    {
        public ListaFornecedor()
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
            DisplayAlert("Search", $"Searching for: {SearchEntry.Text}", "OK");
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            // Handle edit logic
            DisplayAlert("Edit", "Editing SN Embalagens", "OK");
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Handle delete logic
            DisplayAlert("Delete", "Deleting SN Embalagens", "OK");
        }

        private void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
            // Navigate to CadastroFornecedorPage
            Navigation.PushAsync(new CadastroFornecedor());
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Handle back navigation
            Navigation.PopAsync();
        }
    }
}
