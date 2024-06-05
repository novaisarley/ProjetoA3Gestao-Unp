using ProjetoA3Gestao.Model;
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
            ExecuteAsync().Wait();
        }

        public async Task ExecuteAsync()
        {
            await TicketRepository.Instance.RemoveTicketAsync(_ticket);
        }
    }
}
