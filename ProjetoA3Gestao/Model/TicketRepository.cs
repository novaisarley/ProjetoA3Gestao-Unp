using SQLite;
using ProjetoA3Gestao.Model;

namespace ProjetoA3Gestao.Repository
{
    // Padrão de Projeto: Repository
    // Classe TicketRepository fornece uma camada de abstração sobre o acesso aos dados dos tickets,
    // separando a lógica de acesso a dados da lógica de negócios.
    public class TicketRepository
    {
        private readonly SQLiteConnection _database;
        private readonly UsuarioRepository _usuarioRepository;

        public TicketRepository(SQLiteConnection database)
        {
            _database = database;
            _database.CreateTable<Ticket>();
            _usuarioRepository = new UsuarioRepository(database);
        }

        // Retorna uma lista de tickets, carregando manualmente os objetos Usuario associados a cada ticket.
        public List<Ticket> GetTickets()
        {
            var tickets = _database.Table<Ticket>().ToList();

            // Carregar o objeto Usuario manualmente
            foreach (var ticket in tickets)
            {
                ticket.Usuario = _usuarioRepository.GetUsuarioById(ticket.UsuarioId);
            }

            return tickets;
        }

        // Adiciona um novo ticket ao banco de dados.
        public void AddTicket(Ticket ticket)
        {
            // Apenas insira o ID do usuário no ticket antes de salvar
            ticket.UsuarioId = ticket.Usuario.Id;
            _database.Insert(ticket);
        }

        // Remove um ticket do banco de dados.
        public void RemoveTicket(Ticket ticket) => _database.Delete(ticket);

        // Atualiza as informações de um ticket no banco de dados.
        public void UpdateTicket(Ticket ticket)
        {
            // Atualize o ID do usuário antes de salvar
            ticket.UsuarioId = ticket.Usuario.Id;
            _database.Update(ticket);
        }
    }
}
