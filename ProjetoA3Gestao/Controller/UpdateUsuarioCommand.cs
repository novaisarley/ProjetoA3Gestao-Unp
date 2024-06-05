using ProjetoA3Gestao.Model;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Controller
{
    public class UpdateUsuarioCommand : ICommand
    {
        private Usuario _usuario;

        public UpdateUsuarioCommand(Usuario usuario)
        {
            _usuario = usuario;
        }

        public void Execute()
        {
            ExecuteAsync().Wait();
        }

        public async Task ExecuteAsync()
        {
            await UsuarioRepository.Instance.UpdateUsuarioAsync(_usuario);
        }
    }
}
