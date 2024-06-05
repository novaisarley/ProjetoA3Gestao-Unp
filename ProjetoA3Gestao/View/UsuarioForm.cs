using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Model;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoA3Gestao.View
{
    public partial class UsuarioForm : Form
    {
        private UsuarioFactory _usuarioFactory = new ConcreteUsuarioFactory();

        public UsuarioForm()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira o nome.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, insira o e-mail.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Por favor, insira o endereço.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroEndereco.Text))
            {
                MessageBox.Show("Por favor, insira o número do endereço.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                MessageBox.Show("Por favor, insira o CEP.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroTelefone.Text))
            {
                MessageBox.Show("Por favor, insira o número de telefone.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Por favor, insira o CPF.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("E-mail inválido!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidarCep(txtCep.Text))
            {
                MessageBox.Show("CEP inválido!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidarTelefone(txtNumeroTelefone.Text))
            {
                MessageBox.Show("Número de telefone inválido!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("CPF inválido!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(email);
        }

        private bool ValidarCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
                return false;

            var regex = new Regex(@"^\d{5}-\d{3}$");
            return regex.IsMatch(cep);
        }

        private bool ValidarTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
                return false;

            var regex = new Regex(@"^\(?\d{2}\)?[\s-]?\d{4,5}-?\d{4}$");
            return regex.IsMatch(telefone);
        }

        private bool ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            var regex = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
            return regex.IsMatch(cpf);
        }

        private async void btnCreateUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var usuario = _usuarioFactory.CreateUsuario();
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Endereco = txtEndereco.Text;
            usuario.NumeroEndereco = txtNumeroEndereco.Text;
            usuario.Complemento = txtComplemento.Text;
            usuario.Cep = txtCep.Text;
            usuario.NumeroTelefone = txtNumeroTelefone.Text;
            usuario.Cpf = txtCpf.Text;

            var createCommand = new CreateUsuarioCommand(usuario);
            await createCommand.ExecuteAsync();

            await RefreshUsuarioListAsync();
        }

        private async void btnUpdateUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var usuario = (Usuario)lstUsuarios.SelectedItem;
            if (usuario != null)
            {
                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Endereco = txtEndereco.Text;
                usuario.NumeroEndereco = txtNumeroEndereco.Text;
                usuario.Complemento = txtComplemento.Text;
                usuario.Cep = txtCep.Text;
                usuario.NumeroTelefone = txtNumeroTelefone.Text;
                usuario.Cpf = txtCpf.Text;

                var updateCommand = new UpdateUsuarioCommand(usuario);
                await updateCommand.ExecuteAsync();

                await RefreshUsuarioListAsync();
            }
        }

        private async void btnDeleteUsuario_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)lstUsuarios.SelectedItem;
            if (usuario != null)
            {
                var deleteCommand = new DeleteUsuarioCommand(usuario);
                await deleteCommand.ExecuteAsync();

                await RefreshUsuarioListAsync();
            }
        }

        private async Task RefreshUsuarioListAsync()
        {
            lstUsuarios.DataSource = null;
            lstUsuarios.DataSource = await UsuarioRepository.Instance.GetUsuariosAsync();
            lstUsuarios.DisplayMember = "Nome";
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usuario = (Usuario)lstUsuarios.SelectedItem;
            if (usuario != null)
            {
                txtNome.Text = usuario.Nome;
                txtEmail.Text = usuario.Email;
                txtEndereco.Text = usuario.Endereco;
                txtNumeroEndereco.Text = usuario.NumeroEndereco;
                txtComplemento.Text = usuario.Complemento;
                txtCep.Text = usuario.Cep;
                txtNumeroTelefone.Text = usuario.NumeroTelefone;
                txtCpf.Text = usuario.Cpf;
            }
        }

        private async void UsuarioForm_Load(object sender, EventArgs e)
        {
            await RefreshUsuarioListAsync();
        }
    }
}

