using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;

//Classe é responsável pela criação de novos tickets

namespace ProjetoA3Gestao.Controller
{
    //Implementação da interface ICommand
    public class CreateTicketCommand : ICommand
    {
        //Ticket a ser criado e indicação de onde ele será armazenado
        private Ticket _ticket;
        private TicketRepository _ticketRepository;

        //Construtor da classe 
        public CreateTicketCommand(Ticket ticket, TicketRepository ticketRepository)
        {
            _ticket = ticket;
            _ticketRepository = ticketRepository;
        }
        
        //Comando para criar o novo ticket
        public void Execute()
        {
            _ticketRepository.AddTicket(_ticket);
        }
    }
}
