using ProjetoA3Gestao.Model;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Controller
{
    public class CreateTicketCommand : ICommand
    {
        private Ticket _ticket;

        public CreateTicketCommand(Ticket ticket)
        {
            _ticket = ticket;
        }

        public void Execute()
        {
            ExecuteAsync().Wait();
        }

        public async Task ExecuteAsync()
        {
            await TicketRepository.Instance.AddTicketAsync(_ticket);
        }
    }
}
