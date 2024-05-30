using ProjetoA3Gestao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Controller
{
    public class CreateUsuarioCommand : ICommand
    {
        private Usuario _usuario;

        public CreateUsuarioCommand(Usuario usuario)
        {
            _usuario = usuario;
        }

        public void Execute()
        {
            UsuarioRepository.Instance.AddUsuario(_usuario);
        }
    }
}
