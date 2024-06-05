using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

//Classe responsável por realizar uma atualização no cadastro de um usuário

namespace ProjetoA3Gestao.Controller
{
    //Implementação da interface ICommand
    public class UpdateUsuarioCommand : ICommand
    {
        //Indicação do usuário escolhido para ser atualizado e o repositório de seu local
        private Usuario _usuario;
        private UsuarioRepository _usuarioRepository;

        //Construtor da classe
        public UpdateUsuarioCommand(Usuario usuario, UsuarioRepository usuarioRepository)
        {
            _usuario = usuario;
            _usuarioRepository = usuarioRepository; 
        }

        //Comando para atualizar um usuário
        public void Execute()
        {
            _usuarioRepository.UpdateUsuario(_usuario); 
        }
    }
}
