using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

//Classe responsável por remover um usuário da base

namespace ProjetoA3Gestao.Controller
{
    //Implementação da interface ICommand
    public class DeleteUsuarioCommand : ICommand
    {
        //Indicação do usuário escolhido para ser excluido e o repositório de seu local
        private Usuario _usuario;
        private UsuarioRepository _usuarioRepository;

        //Construtor da classe
        public DeleteUsuarioCommand(Usuario usuario, UsuarioRepository usuarioRepository)
        {
            _usuario = usuario;
            _usuarioRepository = usuarioRepository;
        }

        //Comando para remover um usuário
        public void Execute()
        {
            _usuarioRepository.RemoveUsuario(_usuario);
        }
    }
}

