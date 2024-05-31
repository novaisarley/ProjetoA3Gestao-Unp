using System;
using System.Windows.Forms;
using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Controller;
using System.Collections.Generic;

namespace ProjetoA3Gestao
{
    public partial class TicketForm : Form
    {
        private TicketFactory _ticketFactory = new ConcreteTicketFactory();

        public TicketForm()
        {
            InitializeComponent();
            LoadUsuarios();
            InitializeDataGridView();
            RefreshTicketList();
            cmbPrioridade.DataSource = new List<string> { "baixa", "média", "alta", "urgente" };
            cmbStatus.DataSource = new List<string> { "na fila", "em andamento", "fechado", "cancelado" };
        }

        private void LoadUsuarios()
        {
            cmbUsuarios.DataSource = UsuarioRepository.Instance.GetUsuarios();
            cmbUsuarios.DisplayMember = "Nome";
        }

        private void InitializeDataGridView()
        {
            dgvTickets.AutoGenerateColumns = false;
            dgvTickets.Columns.Clear();
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", ReadOnly = true });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", DataPropertyName = "Titulo", ReadOnly = true });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição", DataPropertyName = "Descricao", ReadOnly = true });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status", ReadOnly = true });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Prioridade", DataPropertyName = "Prioridade", ReadOnly = true });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Usuário", DataPropertyName = "Usuario.Nome", ReadOnly = true });
        }

        private void RefreshTicketList()
        {
            dgvTickets.DataSource = null;
            var tickets = TicketRepository.Instance.GetTickets();
            dgvTickets.DataSource = tickets;

            if (tickets.Count > 0)
            {
                dgvTickets.Rows[0].Selected = true;
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

            var createCommand = new CreateTicketCommand(ticket);
            createCommand.Execute();

            RefreshTicketList();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTickets.SelectedRows[0];
                var ticket = (Ticket)selectedRow.DataBoundItem;

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
            if (dgvTickets.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTickets.SelectedRows[0];
                var ticket = (Ticket)selectedRow.DataBoundItem;

                var deleteCommand = new DeleteTicketCommand(ticket);
                deleteCommand.Execute();

                RefreshTicketList();
            }
        }

        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0 && dgvTickets.SelectedRows[0].Index != -1)
            {
                var selectedRow = dgvTickets.SelectedRows[0];
                var selectedRowIndex = dgvTickets.SelectedRows[0].Index;
                var ticket = (Ticket)selectedRow.DataBoundItem;
                txtTitulo.Text = ticket.Titulo;
                txtDescricao.Text = ticket.Descricao;
                cmbStatus.SelectedItem = ticket.Status;
                cmbPrioridade.SelectedItem = ticket.Prioridade;
                //cmbUsuarios.SelectedItem = ticket.Usuario;

                dgvTickets.Rows[selectedRowIndex].Selected = true;
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
    }
}
