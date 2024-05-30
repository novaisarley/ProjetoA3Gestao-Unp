using System;
using System.Windows.Forms;
using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Controller;

namespace ProjetoA3Gestao
{
    public partial class TicketForm : Form
    {
        private TicketFactory _ticketFactory = new ConcreteTicketFactory();

        public TicketForm()
        {
            InitializeComponent();
            LoadUsuarios();
            RefreshTicketList();
            cmbPrioridade.DataSource = new List<string> { "baixa", "média", "alta", "urgente" };
            cmbStatus.DataSource = new List<string> { "na fila", "em andamento", "fechado", "cancelado" };
        }

        private void LoadUsuarios()
        {
            cmbUsuarios.DataSource = UsuarioRepository.Instance.GetUsuarios();
            cmbUsuarios.DisplayMember = "Nome";
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            var ticket = _ticketFactory.CreateTicket();
            ticket.Titulo = txtTitulo.Text;
            ticket.Descricao = txtDescricao.Text;
            ticket.Status = cmbStatus.SelectedItem.ToString();
            ticket.Prioridade = cmbPrioridade.SelectedItem.ToString();
            ticket.Usuario = (Usuario)cmbUsuarios.SelectedItem;

            var createCommand = new CreateTicketCommand(ticket);
            createCommand.Execute();

            RefreshTicketList();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            var ticket = (Ticket)lstTickets.SelectedItem;
            if (ticket != null)
            {
                ticket.Titulo = txtTitulo.Text;
                ticket.Descricao = txtDescricao.Text;
                ticket.Status = cmbStatus.SelectedItem.ToString();
                ticket.Prioridade = cmbPrioridade.SelectedItem.ToString();
                ticket.Usuario = (Usuario)cmbUsuarios.SelectedItem;

                var updateCommand = new UpdateTicketCommand(ticket);
                updateCommand.Execute();

                RefreshTicketList();
            }
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            var ticket = (Ticket)lstTickets.SelectedItem;
            if (ticket != null)
            {
                var deleteCommand = new DeleteTicketCommand(ticket);
                deleteCommand.Execute();

                RefreshTicketList();
            }
        }

        private void RefreshTicketList()
        {
            lstTickets.DataSource = null;
            lstTickets.DataSource = TicketRepository.Instance.GetTickets();
            lstTickets.DisplayMember = "Titulo";
        }

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ticket = (Ticket)lstTickets.SelectedItem;
            if (ticket != null)
            {
                txtTitulo.Text = ticket.Titulo;
                txtDescricao.Text = ticket.Descricao;
                cmbStatus.SelectedItem = ticket.Status;
                cmbPrioridade.SelectedItem = ticket.Prioridade;
                cmbUsuarios.SelectedItem = ticket.Usuario;
            }
        }
    }
}
