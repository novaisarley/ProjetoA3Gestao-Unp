using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

//Classe responsável por realizar uma atualização no cadastro de um ticket

namespace ProjetoA3Gestao.Controller
{
    //Implementação da interface ICommand
    public class UpdateTicketCommand : ICommand
    {
        //Indicação do ticket escolhido para ser atualizado e o repositório de seu local
        private Ticket _ticket;
        private TicketRepository _ticketRepository;

        //Construtor da classe
        public UpdateTicketCommand(Ticket ticket, TicketRepository ticketRepository)
        {
            _ticket = ticket;
            _ticketRepository = ticketRepository;
        }

        //Comando para atualizar um ticket
        public void Execute()
        {
            _ticketRepository.UpdateTicket(_ticket);
        }
    }
}
