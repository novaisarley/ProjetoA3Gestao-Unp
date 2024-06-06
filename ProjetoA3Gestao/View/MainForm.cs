namespace ProjetoA3Gestao.View
{
    // Classe responsável pela interface principal da aplicação
    public partial class MainForm : Form
    {
        // Construtor da classe
        public MainForm()
        {
            // Inicializa os componentes visuais do formulário
            InitializeComponent();
        }

        // Método de evento para o botão de gerenciamento de usuários
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de gerenciamento de usuários
            var usuarioForm = new UsuarioForm();
            // Exibe o formulário de gerenciamento de usuários
            usuarioForm.Show();
        }

        // Método de evento para o botão de gerenciamento de tickets
        private void btnManageTickets_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de gerenciamento de tickets
            var ticketForm = new TicketForm();
            // Exibe o formulário de gerenciamento de tickets
            ticketForm.Show();
        }
    }
}

