using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

//Classe responsável por excluir tickets

namespace ProjetoA3Gestao.Controller
{
    //Implementação da interface ICommand
    public class DeleteTicketCommand : ICommand
    {
        //Indicação do ticket escolhido para ser excluido e o repositório de seu local
        private Ticket _ticket;
        private TicketRepository _ticketRepository;

        //Construtor da classe
        public DeleteTicketCommand(Ticket ticket, TicketRepository ticketRepository)
        {
            _ticket = ticket;
            _ticketRepository = ticketRepository;
        }

        //Comando para remover um ticket
        public void Execute()
        {
            _ticketRepository.RemoveTicket(_ticket);
        }
    }
}
