using ProjetoA3Gestao.Model;
using SQLite;

namespace ProjetoA3Gestao.Repository
{
    public class UsuarioRepository
    {
        private readonly SQLiteConnection _database;

        public UsuarioRepository(SQLiteConnection database)
        {
            _database = database;
            _database.CreateTable<Usuario>();
        }

        public List<Usuario> GetUsuarios() => _database.Table<Usuario>().ToList();

        public Usuario GetUsuarioById(int id) => _database.Find<Usuario>(id);

        public void AddUsuario(Usuario usuario) => _database.Insert(usuario);

        public void RemoveUsuario(Usuario usuario) => _database.Delete(usuario);

        public void UpdateUsuario(Usuario usuario) => _database.Update(usuario);
    }
}
