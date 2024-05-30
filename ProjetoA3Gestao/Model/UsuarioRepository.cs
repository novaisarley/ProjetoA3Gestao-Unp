using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Model
{
    public class UsuarioRepository
    {
        private static UsuarioRepository _instance;
        private List<Usuario> _usuarios;

        private UsuarioRepository()
        {
            _usuarios = new List<Usuario>();
        }

        public static UsuarioRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsuarioRepository();
                }
                return _instance;
            }
        }

        public List<Usuario> GetUsuarios() => _usuarios;

        public void AddUsuario(Usuario usuario) => _usuarios.Add(usuario);

        public void RemoveUsuario(Usuario usuario) => _usuarios.Remove(usuario);

        public void UpdateUsuario(Usuario usuario)
        {
            var index = _usuarios.FindIndex(u => u.Id == usuario.Id);
            if (index != -1)
            {
                _usuarios[index] = usuario;
            }
        }
    }
}
