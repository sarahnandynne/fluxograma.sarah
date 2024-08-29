using Microsoft.Maui.Controls;
using Modelos;

namespace projetosarah
{
    public partial class Lista : ContentPage
    {
        Controles.ControleCliente clienteControle = new Controles.ControleCliente();
        public Lista()
        {
            InitializeComponent();
            SearchButton.Clicked += OnSearchButtonClicked;
            EditButton.Clicked += OnEditButtonClicked;
            DeleteButton.Clicked += OnDeleteButtonClicked;
            CadastrarButton.Clicked += OnCadastrarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListaClientes.ItemsSource = clienteControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroClientePage,
            // que é a página onde os dados do cliente podem ser criados/editados
            var page = new CadastroCliente();
            // O passo seguinte é dizer para nova página qual cliente foi selecionado. Olhe o código da CadastroClientePage,
            // e verifique que lá terá um atributo público do tipo Cliente, chamado cliente.
            // Toda vez que se clica em um cliente na lista nessa página, setaremos na CadastroClientePage o atributo cliente 
            // com o cliente que foi clicado aqui.
            page.cliente = e.SelectedItem as Cliente;
            // Troca-se a página principal para a página que acabamos de criar
            Application.Current.MainPage = page;
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
