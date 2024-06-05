using SQLite;
using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

//Classe responsável por gerenciar a conexão com o banco de dados

namespace ProjetoA3Gestao.Data
{
    public class Database
    {
        //Conexão com o banco de dados
        private readonly SQLiteConnection _connection;

        //Obtém o repositório de usuários
        public UsuarioRepository UsuarioRepository { get; }

        //Obtém o repositório de tickets
        public TicketRepository TicketRepository { get; }

        //Construtor da classe database
        public Database()
        {
            string databasePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "projetoa3gestao.db3");
            _connection = new SQLiteConnection(databasePath);
            //Cria as tabelas dentro do banco se elas não existirem
            _connection.CreateTable<Usuario>();
            _connection.CreateTable<Ticket>();

            //Inicia repositórios com a conexão ao banco de dados
            UsuarioRepository = new UsuarioRepository(_connection);
            TicketRepository = new TicketRepository(_connection);
        }
    }
}
