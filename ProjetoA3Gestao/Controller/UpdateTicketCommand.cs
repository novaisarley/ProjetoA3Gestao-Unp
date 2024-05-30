using ProjetoA3Gestao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Controller
{
    public class UpdateTicketCommand : ICommand
    {
        private Ticket _ticket;

        public UpdateTicketCommand(Ticket ticket)
        {
            _ticket = ticket;
        }

        public void Execute()
        {
            TicketRepository.Instance.UpdateTicket(_ticket);
        }
    }
}
