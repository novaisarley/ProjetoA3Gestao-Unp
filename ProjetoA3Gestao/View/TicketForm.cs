using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Model;

namespace ProjetoA3Gestao
{
    public partial class TicketForm : Form
    {
        private TicketFactory _ticketFactory = new ConcreteTicketFactory();

        public TicketForm()
        {
            InitializeComponent();
            _ = LoadUsuariosAsync();
            _ = RefreshTicketListAsync();
            InitializeListBox();
            cmbPrioridade.DataSource = new List<string> { "baixa", "média", "alta", "urgente" };
            cmbStatus.DataSource = new List<string> { "na fila", "em andamento", "fechado", "cancelado" };
        }

        private async Task LoadUsuariosAsync()
        {
            cmbUsuarios.DataSource = await UsuarioRepository.Instance.GetUsuariosAsync();
            cmbUsuarios.DisplayMember = "Nome";
        }

        private void InitializeListBox()
        {
            lstTickets.Items.Clear();
        }

        private async Task RefreshTicketListAsync()
        {
            lstTickets.Items.Clear();
            var tickets = await TicketRepository.Instance.GetTicketsAsync();
            foreach (var ticket in tickets)
            {
                var displayText = $"Título: {ticket.Titulo} | Status: {ticket.Status} | Prioridade: ({ticket.Prioridade})";
                lstTickets.Items.Add(new ListBoxItem { DisplayText = displayText, Ticket = ticket });
            }

            if (tickets.Count > 0)
            {
                lstTickets.SelectedIndex = 0;
            }
        }

        private async void btnCreateTicket_Click(object sender, EventArgs e)
        {
            var ticket = _ticketFactory.CreateTicket();
            ticket.Titulo = txtTitulo.Text;
            ticket.Descricao = txtDescricao.Text;
            ticket.Status = cmbStatus.SelectedItem.ToString();
            ticket.Prioridade = cmbPrioridade.SelectedItem.ToString();
            ticket.Usuario = (Usuario)cmbUsuarios.SelectedItem;

            var createCommand = new CreateTicketCommand(ticket);
            await createCommand.ExecuteAsync();

            await RefreshTicketListAsync();
        }

        private async void btnUpdateTicket_Click(object sender, EventArgs e)
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

                var updateCommand = new UpdateTicketCommand(ticket);
                await updateCommand.ExecuteAsync();

                await RefreshTicketListAsync();
            }
        }

        private async void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItem != null)
            {
                var selectedItem = (ListBoxItem)lstTickets.SelectedItem;
                var ticket = selectedItem.Ticket;

                var deleteCommand = new DeleteTicketCommand(ticket);
                await deleteCommand.ExecuteAsync();

                await RefreshTicketListAsync();
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
