using System;
using Microsoft.Maui.Controls;
using Modelos;

namespace projetosarah
{
    public partial class CadastroCliente : ContentPage
    {
        public Cliente cliente { get; set; }
        Controles.ControleCliente clienteControle = new Controles.ControleCliente();

        public CadastroCliente()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                IdLabel.Text = cliente.Id.ToString();
                NomeEntry.Text = cliente.Nome;
                TelefoneEntry.Text = cliente.Telefone;
            }
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
            var cliente = new Modelos.Cliente();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                cliente.Id = int.Parse(IdLabel.Text);
            else
                cliente.Id = 0;
            cliente.Nome = NomeEntry.Text;
            cliente.Telefone = TelefoneEntry.Text;
            // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
            clienteControle.CriarOuAtualizar(cliente);
            // Mostra a mensagem de sucesso
            DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar o cadastro
            DisplayAlert("Atualizar", "Cadastro atualizado com sucesso!", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}
