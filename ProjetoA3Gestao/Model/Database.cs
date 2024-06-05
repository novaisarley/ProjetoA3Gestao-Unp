using SQLite;
using System.IO;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Model
{
    public class Database
    {
        private static SQLiteAsyncConnection _database;

        public static async Task<SQLiteAsyncConnection> GetDatabase()
        {
            if (_database == null)
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjetoA3Gestao.db3");
                _database = new SQLiteAsyncConnection(databasePath);
                await InitializeDatabase();
            }

            return _database;
        }

        private static async Task InitializeDatabase()
        {
            // Criação das tabelas
            await _database.CreateTableAsync<Usuario>();
            await _database.CreateTableAsync<Ticket>();
        }
    }
}
