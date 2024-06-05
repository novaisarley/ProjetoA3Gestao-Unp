using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

//Classe é responsável pela criação de novos usuários

namespace ProjetoA3Gestao.Controller
{
    //Implementação da interface ICommand
    public class CreateUsuarioCommand : ICommand
    {
        //Usuário a ser criado e indicação de onde ele será armazenado
        private Usuario _usuario;
        private UsuarioRepository _usuarioRepository;

        //Construtor da classe
        public CreateUsuarioCommand(Usuario usuario, UsuarioRepository usuarioRepository)
        {
            _usuario = usuario;
            _usuarioRepository = usuarioRepository;
        }

        //Comando para criar o novo usuário
        public void Execute()
        {
            _usuarioRepository.AddUsuario(_usuario);
        }
    }
}
