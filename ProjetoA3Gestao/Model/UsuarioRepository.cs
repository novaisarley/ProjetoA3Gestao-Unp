using ProjetoA3Gestao.Model;
using SQLite;

namespace ProjetoA3Gestao.Repository
{
    // Padrão de Projeto: Repository
    // Classe UsuarioRepository fornece uma camada de abstração sobre o acesso aos dados dos usuários,
    // separando a lógica de acesso a dados da lógica de negócios.
    public class UsuarioRepository
    {
        private readonly SQLiteConnection _database;

        public UsuarioRepository(SQLiteConnection database)
        {
            _database = database;
            _database.CreateTable<Usuario>();
        }

        // Retorna uma lista de todos os usuários do banco de dados.
        public List<Usuario> GetUsuarios() => _database.Table<Usuario>().ToList();

        // Retorna um usuário com o ID especificado do banco de dados.
        public Usuario GetUsuarioById(int id) => _database.Find<Usuario>(id);

        // Adiciona um novo usuário ao banco de dados.
        public void AddUsuario(Usuario usuario) => _database.Insert(usuario);

        // Remove um usuário do banco de dados.
        public void RemoveUsuario(Usuario usuario) => _database.Delete(usuario);

        // Atualiza as informações de um usuário no banco de dados.
        public void UpdateUsuario(Usuario usuario) => _database.Update(usuario);
    }
}
