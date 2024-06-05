using ProjetoA3Gestao.Model;
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
            ExecuteAsync().Wait();
        }

        public async Task ExecuteAsync()
        {
            await TicketRepository.Instance.UpdateTicketAsync(_ticket);
        }
    }
}
