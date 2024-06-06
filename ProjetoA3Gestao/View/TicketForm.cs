using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetoA3Gestao
{
    //Classe que representa o formul�rio de gerenciamento dos tickets
    public partial class TicketForm : Form
    {
        private TicketFactory _ticketFactory = new ConcreteTicketFactory();
        private SQLiteConnection _database;
        private TicketRepository _ticketRepository;
        private UsuarioRepository _usuarioRepository;

        public TicketForm()
        {
            InitializeComponent();

            // Inicialize a conex�o SQLite e passe-a para os reposit�rios
            _database = new SQLiteConnection("Data Source=database.db;Version=3;");
            _ticketRepository = new TicketRepository(_database);
            _usuarioRepository = new UsuarioRepository(_database);

            LoadUsuarios();
            InitializeListBox();
            RefreshTicketList();
            cmbPrioridade.DataSource = new List<string> { "baixa", "m�dia", "alta", "urgente" };
            cmbStatus.DataSource = new List<string> { "na fila", "em andamento", "fechado", "cancelado" };
            ClearForm();
        }

        //Carrega a ComboBox de usu�rios
        private void LoadUsuarios()
        {
            cmbUsuarios.DataSource = _usuarioRepository.GetUsuarios();
            cmbUsuarios.DisplayMember = "Nome";
        }

        //Inicializa lista de tickets
        private void InitializeListBox()
        {
            lstTickets.Items.Clear();
        }

        //Atualiza lista de tickets
        private void RefreshTicketList()
        {
            lstTickets.Items.Clear();
            var tickets = _ticketRepository.GetTickets();
            foreach (var ticket in tickets)
            {
                var displayText = $"T�tulo: {ticket.Titulo} | Status: {ticket.Status} | Prioridade: ({ticket.Prioridade}) | User: {ticket.Usuario.Nome} {ticket.Usuario.Id}";
                lstTickets.Items.Add(new ListBoxItem { DisplayText = displayText, Ticket = ticket });
            }

            if (tickets.Count > 0)
            {
                lstTickets.SelectedIndex = 0;
            }
        }

        //Limpa o formul�rio
        private void ClearForm()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbPrioridade.SelectedIndex = -1;
            cmbUsuarios.SelectedIndex = -1;
        }

        //Valida��o dos campos inseridos no formul�rio
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Por favor, insira o t�tulo.", "Campo obrigat�rio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, insira a descri��o.", "Campo obrigat�rio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o status.", "Campo obrigat�rio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbPrioridade.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione a prioridade.", "Campo obrigat�rio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um usu�rio.", "Campo obrigat�rio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Bot�o de criar ticket
        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var ticket = _ticketFactory.CreateTicket();
            ticket.Titulo = txtTitulo.Text;
            ticket.Descricao = txtDescricao.Text;
            ticket.Status = cmbStatus.SelectedItem.ToString();
            ticket.Prioridade = cmbPrioridade.SelectedItem.ToString();
            ticket.Usuario = (Usuario)cmbUsuarios.SelectedItem;

            var createCommand = new CreateTicketCommand(ticket, _ticketRepository);
            createCommand.Execute();

            RefreshTicketList();
            ClearForm();
        }

        //Bot�o de atualizar ticket
        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItem != null)
            {
                if (!ValidarCampos())
                    return;

                var selectedItem = (ListBoxItem)lstTickets.SelectedItem;
                var ticket = selectedItem.Ticket;

                ticket.Titulo = txtTitulo.Text;
                ticket.Descricao = txtDescricao.Text;
                ticket.Status = cmbStatus.SelectedItem.ToString();
                ticket.Prioridade = cmbPrioridade.SelectedItem.ToString();
                ticket.Usuario = (Usuario)cmbUsuarios.SelectedItem;
                ticket.UsuarioId = ticket.Usuario.Id;

                var updateCommand = new UpdateTicketCommand(ticket, _ticketRepository);
                updateCommand.Execute();

                RefreshTicketList();
                ClearForm();
            }
        }

        //Bot�o de deletar ticket
        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItem != null)
            {
                var selectedItem = (ListBoxItem)lstTickets.SelectedItem;
                var ticket = selectedItem.Ticket;

                var deleteCommand = new DeleteTicketCommand(ticket, _ticketRepository);
                deleteCommand.Execute();

                RefreshTicketList();
                ClearForm();
            }
        }

        //Atualiza dados do formul�rio com ticket selecionado
        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItem != null)
            {
                var selectedItem = (ListBoxItem)lstTickets.SelectedItem;
                var ticket = selectedItem.Ticket;

                txtTitulo.Text = ticket.Titulo;
                txtDescricao.Text = ticket.Descricao;
                cmbStatus.SelectedItem = ticket.Status;
                cmbPrioridade.SelectedItem = ticket.Prioridade;
                cmbUsuarios.SelectedItem = _usuarioRepository.GetUsuarios().FirstOrDefault(u => u.Id == ticket.UsuarioId);
            }
            else
            {
                ClearForm();
            }
        }

        //Instancia a lista de tickets
        private class ListBoxItem
        {
            public string DisplayText { get; set; }
            public Ticket Ticket { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }
    }
}
