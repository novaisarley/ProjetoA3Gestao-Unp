namespace ProjetoA3Gestao.Controller
{
    // Padrão de Projeto: Command
    // Interface ICommand define um contrato para classes que representam comandos executáveis,
    // permitindo encapsular solicitações como objetos e suportar operações que podem ser desfeitas.
    public interface ICommand
    {
        void Execute();
    }
}
