namespace ProjetoA3Gestao.Model
{
    public abstract class UsuarioFactory
    {
        public abstract Usuario CreateUsuario();
    }
    // Padrão de Projeto: Factory
    // Classe ConcreteUsuarioFactory implementa a interface UsuarioFactory para criar objetos Usuario,
    // permitindo a criação de instâncias concretas de Usuario com base nas necessidades do sistema.
    public class ConcreteUsuarioFactory : UsuarioFactory
    {
        private static int _idCounter;

        public ConcreteUsuarioFactory()
        {
            // Inicialize o contador de ID com o valor armazenado em um arquivo
            _idCounter = LoadLastUsedId();
        }

        public override Usuario CreateUsuario()
        {
            return new Usuario { Id = _idCounter++ };
        }

        private int LoadLastUsedId()
        {
            // Verifique se o arquivo de contador existe
            if (File.Exists("last_used_id.txt"))
            {
                // Se existir, leia o valor do arquivo e retorne
                string content = File.ReadAllText("last_used_id.txt");
                if (int.TryParse(content, out int id))
                {
                    return id;
                }
            }

            // Se o arquivo não existir ou não puder ser lido, retorne 1 como valor padrão
            return 1;
        }

        private void SaveLastUsedId()
        {
            // Salve o valor atual do contador em um arquivo
            File.WriteAllText("last_used_id.txt", _idCounter.ToString());
        }

        // Certifique-se de chamar este método quando a aplicação estiver sendo encerrada
        public void OnApplicationExit()
        {
            SaveLastUsedId();
        }
    }
}