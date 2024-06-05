using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository; // Importe o namespace onde está a classe UsuarioRepository
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Controller
{
    public class UpdateUsuarioCommand : ICommand
    {
        private Usuario _usuario;
        private UsuarioRepository _usuarioRepository; // Adicione uma referência para UsuarioRepository

        public UpdateUsuarioCommand(Usuario usuario, UsuarioRepository usuarioRepository)
        {
            _usuario = usuario;
            _usuarioRepository = usuarioRepository; // Passe uma instância válida de UsuarioRepository
        }

        public void Execute()
        {
            _usuarioRepository.UpdateUsuario(_usuario); // Use a instância de UsuarioRepository passada no construtor
        }
    }
}
