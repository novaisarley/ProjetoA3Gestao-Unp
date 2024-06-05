using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

namespace ProjetoA3Gestao.Controller
{
    public class CreateTicketCommand : ICommand
    {
        private Ticket _ticket;
        private TicketRepository _ticketRepository;

        public CreateTicketCommand(Ticket ticket, TicketRepository ticketRepository)
        {
            _ticket = ticket;
            _ticketRepository = ticketRepository;
        }

        public void Execute()
        {
            _ticketRepository.AddTicket(_ticket);
        }
    }
}
