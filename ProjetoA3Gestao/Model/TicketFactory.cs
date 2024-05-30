using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Model
{
    public abstract class TicketFactory
    {
        public abstract Ticket CreateTicket();
    }

    public class ConcreteTicketFactory : TicketFactory
    {
        private static int _idCounter = 1;

        public override Ticket CreateTicket()
        {
            return new Ticket { Id = _idCounter++ };
        }
    }
}
