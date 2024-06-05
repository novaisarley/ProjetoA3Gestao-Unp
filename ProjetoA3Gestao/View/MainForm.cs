using System;
using System.Windows.Forms;

namespace ProjetoA3Gestao.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            var usuarioForm = new UsuarioForm();
            usuarioForm.Show();
        }

        private void btnManageTickets_Click(object sender, EventArgs e)
        {
            var ticketForm = new TicketForm();
            ticketForm.Show();
        }
    }
}
