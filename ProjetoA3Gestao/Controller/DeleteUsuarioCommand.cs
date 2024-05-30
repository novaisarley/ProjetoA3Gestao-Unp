using ProjetoA3Gestao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Controller
{
    public class DeleteUsuarioCommand : ICommand
    {
        private Usuario _usuario;

        public DeleteUsuarioCommand(Usuario usuario)
        {
            _usuario = usuario;
        }

        public void Execute()
        {
            UsuarioRepository.Instance.RemoveUsuario(_usuario);
        }
    }
}
