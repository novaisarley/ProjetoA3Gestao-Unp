using SQLite;
using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;
using System.IO;

namespace ProjetoA3Gestao.Data
{
    public class Database
    {
        private readonly SQLiteConnection _connection;

        public UsuarioRepository UsuarioRepository { get; }
        public TicketRepository TicketRepository { get; }

        public Database()
        {
            string databasePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "projetoa3gestao.db3");
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<Usuario>();
            _connection.CreateTable<Ticket>();

            UsuarioRepository = new UsuarioRepository(_connection);
            TicketRepository = new TicketRepository(_connection);
        }
    }
}
