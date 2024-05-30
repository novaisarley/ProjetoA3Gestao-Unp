using ProjetoA3Gestao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Controller
{
    public class DeleteTicketCommand : ICommand
    {
        private Ticket _ticket;

        public DeleteTicketCommand(Ticket ticket)
        {
            _ticket = ticket;
        }

        public void Execute()
        {
            TicketRepository.Instance.RemoveTicket(_ticket);
        }

    }
}
