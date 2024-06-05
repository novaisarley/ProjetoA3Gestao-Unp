using ProjetoA3Gestao.View;

namespace ProjetoA3Gestao
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}