using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Model
{
    public class TicketRepository
    {
        private static TicketRepository _instance;
        private List<Ticket> _tickets;

        private TicketRepository()
        {
            _tickets = new List<Ticket>();
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

        public List<Ticket> GetTickets() => _tickets;

        public void AddTicket(Ticket ticket) => _tickets.Add(ticket);

        public void RemoveTicket(Ticket ticket) => _tickets.Remove(ticket);

        public void UpdateTicket(Ticket ticket)
        {
            var index = _tickets.FindIndex(t => t.Id == ticket.Id);
            if (index != -1)
            {
                _tickets[index] = ticket;
            }
        }
    }
}
