using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Model
{
    public class UsuarioRepository
    {
        private static UsuarioRepository _instance;
        private SQLiteAsyncConnection _database;
        private List<Usuario> _usuarios;

        private UsuarioRepository()
        {
            InitializeDatabase().Wait();
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

        private async Task InitializeDatabase()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjetoA3Gestao.db3");
            _database = new SQLiteAsyncConnection(databasePath);
            await _database.CreateTableAsync<Usuario>();
            _usuarios = await _database.Table<Usuario>().ToListAsync(); // Carregar usuários do banco de dados
        }

        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            _usuarios = await _database.Table<Usuario>().ToListAsync();
            return _usuarios;
        }

        public async Task AddUsuarioAsync(Usuario usuario)
        {
            await _database.InsertAsync(usuario);
            _usuarios.Add(usuario);
        }

        public async Task RemoveUsuarioAsync(Usuario usuario)
        {
            await _database.DeleteAsync(usuario);
            _usuarios.Remove(usuario);
        }

        public async Task UpdateUsuarioAsync(Usuario usuario)
        {
            var index = _usuarios.FindIndex(u => u.Id == usuario.Id);
            if (index != -1)
            {
                _usuarios[index] = usuario;
                await _database.UpdateAsync(usuario);
            }
        }
    }
}

