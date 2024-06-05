using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Model
{
    public class TicketRepository
    {
        private static TicketRepository _instance;
        private SQLiteAsyncConnection _database;
        private List<Ticket> _tickets;

        private TicketRepository()
        {
            InitializeDatabase().Wait();
        }

        public static TicketRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TicketRepository();
                }
                return _instance;
            }
        }

        private async Task InitializeDatabase()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjetoA3Gestao.db3");
            _database = new SQLiteAsyncConnection(databasePath);
            await _database.CreateTableAsync<Ticket>();
            _tickets = await _database.Table<Ticket>().ToListAsync(); // Carregar tickets do banco de dados
        }

        public async Task<List<Ticket>> GetTicketsAsync()
        {
            _tickets = await _database.Table<Ticket>().ToListAsync();
            return _tickets;
        }

        public async Task AddTicketAsync(Ticket ticket)
        {
            await _database.InsertAsync(ticket);
            _tickets.Add(ticket);
        }

        public async Task RemoveTicketAsync(Ticket ticket)
        {
            await _database.DeleteAsync(ticket);
            _tickets.Remove(ticket);
        }

        public async Task UpdateTicketAsync(Ticket ticket)
        {
            var index = _tickets.FindIndex(t => t.Id == ticket.Id);
            if (index != -1)
            {
                _tickets[index] = ticket;
                await _database.UpdateAsync(ticket);
            }
        }
    }
}

