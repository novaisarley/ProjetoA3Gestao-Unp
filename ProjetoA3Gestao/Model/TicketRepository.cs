using SQLite;
using ProjetoA3Gestao.Model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoA3Gestao.Repository
{
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

        public void AddTicket(Ticket ticket)
        {
            // Apenas insira o ID do usuário no ticket antes de salvar
            ticket.UsuarioId = ticket.Usuario.Id;
            _database.Insert(ticket);
        }

        public void RemoveTicket(Ticket ticket) => _database.Delete(ticket);

        public void UpdateTicket(Ticket ticket)
        {
            // Atualize o ID do usuário antes de salvar
            ticket.UsuarioId = ticket.Usuario.Id;
            _database.Update(ticket);
        }
    }
}

