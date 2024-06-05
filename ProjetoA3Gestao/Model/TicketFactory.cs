﻿

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

            Ticket ticket = new Ticket{ Id = _idCounter++ };
            Usuario usuario = new Usuario { Nome = "UserTeste" };
            ticket.Usuario = usuario;

            return ticket;
        }
    }
}
