using System;
using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace projetosarah
{
    public partial class CadastroFornecedorPage : ContentPage
    {
         public Fornecedor fornecedor { get; set; }
        Controles.ControleFornecedor clienteControle = new Controles.ControleFornecedor();
        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (fornecedor != null)
            {
                IdLabel.Text = fornecedor.Id.ToString();
                NomeEntry.Text = fornecedor.Nome;
                TelefoneEntry.Text = fornecedor.Telefone;
                EmailEntry.Text = fornecedor.email;
                CnpjEntry.Text = fornecedor.CNPJ;
            }
        }
        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
            var fornecedor = new Modelos.Fornecedor();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                fornecedor.Id = int.Parse(IdLabel.Text);
            else
                fornecedor.Id = 0;
            fornecedor.Nome = NomeEntry.Text;
            fornecedor.Telefone = TelefoneEntry.Text;
            fornecedor.email = EmailEntry.Text;
            fornecedor.CNPJ = CnpjEntry.Text;
            // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
            clienteControle.CriarOuAtualizar(fornecedor);
            // Mostra a mensagem de sucesso
            DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            if (Application.Current != null)
                Application.Current.MainPage = new Lista();
            
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar o cadastro
            DisplayAlert("ATUALIZAR", "Cadastro atualizado com sucesso!", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}