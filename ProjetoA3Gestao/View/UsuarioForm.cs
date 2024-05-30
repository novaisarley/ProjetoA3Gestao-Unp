using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnCreateUsuario_Click(object sender, EventArgs e)
        {
            var usuario = _usuarioFactory.CreateUsuario();
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Endereco = txtEndereco.Text;
            usuario.Cep = txtCep.Text;
            usuario.NumeroTelefone = txtNumeroTelefone.Text;
            usuario.Cpf = txtCpf.Text;

            var createCommand = new CreateUsuarioCommand(usuario);
            createCommand.Execute();

            RefreshUsuarioList();
        }

        private void btnUpdateUsuario_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)lstUsuarios.SelectedItem;
            if (usuario != null)
            {
                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Endereco = txtEndereco.Text;
                usuario.Cep = txtCep.Text;
                usuario.NumeroTelefone = txtNumeroTelefone.Text;
                usuario.Cpf = txtCpf.Text;

                var updateCommand = new UpdateUsuarioCommand(usuario);
                updateCommand.Execute();

                RefreshUsuarioList();
            }
        }

        private void btnDeleteUsuario_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)lstUsuarios.SelectedItem;
            if (usuario != null)
            {
                var deleteCommand = new DeleteUsuarioCommand(usuario);
                deleteCommand.Execute();

                RefreshUsuarioList();
            }
        }

        private void RefreshUsuarioList()
        {
            lstUsuarios.DataSource = null;
            lstUsuarios.DataSource = UsuarioRepository.Instance.GetUsuarios();
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
                txtCep.Text = usuario.Cep;
                txtNumeroTelefone.Text = usuario.NumeroTelefone;
                txtCpf.Text = usuario.Cpf;
            }
        }
    }
}
