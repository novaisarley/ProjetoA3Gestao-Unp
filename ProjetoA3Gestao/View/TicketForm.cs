using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;
using SQLite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoA3Gestao
{
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
        }

        private void LoadUsuarios()
        {
            cmbUsuarios.DataSource = _usuarioRepository.GetUsuarios();
            cmbUsuarios.DisplayMember = "Nome";
        }

        private void InitializeListBox()
        {
            lstTickets.Items.Clear();
        }

        private void RefreshTicketList()
        {
            lstTickets.Items.Clear();
            var tickets = _ticketRepository.GetTickets();
            foreach (var ticket in tickets)
            {
                var displayText = $"T�tulo: {ticket.Titulo} | Status: {ticket.Status} | Prioridade: ({ticket.Prioridade})";
                lstTickets.Items.Add(new ListBoxItem { DisplayText = displayText, Ticket = ticket });
            }

            if (tickets.Count > 0)
            {
                lstTickets.SelectedIndex = 0;
            }
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            var ticket = _ticketFactory.CreateTicket();
            ticket.Titulo = txtTitulo.Text;
            ticket.Descricao = txtDescricao.Text;
            ticket.Status = cmbStatus.SelectedItem.ToString();
            ticket.Prioridade = cmbPrioridade.SelectedItem.ToString();
            ticket.Usuario = (Usuario)cmbUsuarios.SelectedItem;

            var createCommand = new CreateTicketCommand(ticket, _ticketRepository);
            createCommand.Execute();

            RefreshTicketList();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItem != null)
            {
                var selectedItem = (ListBoxItem)lstTickets.SelectedItem;
                var ticket = selectedItem.Ticket;

                ticket.Titulo = txtTitulo.Text;
                ticket.Descricao = txtDescricao.Text;
                ticket.Status = cmbStatus.SelectedItem.ToString();
                ticket.Prioridade = cmbPrioridade.SelectedItem.ToString();
                ticket.Usuario = (Usuario)cmbUsuarios.SelectedItem;

                var updateCommand = new UpdateTicketCommand(ticket, _ticketRepository);
                updateCommand.Execute();

                RefreshTicketList();
            }
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItem != null)
            {
                var selectedItem = (ListBoxItem)lstTickets.SelectedItem;
                var ticket = selectedItem.Ticket;

                var deleteCommand = new DeleteTicketCommand(ticket, _ticketRepository);
                deleteCommand.Execute();

                RefreshTicketList();
            }
        }

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
                cmbUsuarios.SelectedItem = ticket.Usuario;
            }
            else
            {
                txtTitulo.Clear();
                txtDescricao.Clear();
                cmbStatus.SelectedIndex = -1;
                cmbPrioridade.SelectedIndex = -1;
                cmbUsuarios.SelectedIndex = -1;
            }
        }

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

