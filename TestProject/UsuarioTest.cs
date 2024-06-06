using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Data;
using ProjetoA3Gestao.Model;
using ProjetoA3Gestao.Repository;
using SQLite;
using System.Linq;
using Xunit;

namespace TestProject
{
    public class UsuarioTest
    {
        private readonly UsuarioFactory _usuarioFactory = new ConcreteUsuarioFactory();
        private SQLiteConnection _database;
        private TicketRepository _ticketRepository;
        private UsuarioRepository _usuarioRepository;

        private SQLiteConnection CreateDatabaseConnection()
        {
            _database = new SQLiteConnection("Data Source=database.db;Version=3;");
            _ticketRepository = new TicketRepository(_database);
            _usuarioRepository = new UsuarioRepository(_database);
            return _database;
        }

        [Fact(DisplayName = "Testa a validade da criação de um usuario")]
        public void CriaUsuario()
        {
            // Arrange
            Usuario usuario = _usuarioFactory.CreateUsuario();
            usuario.Nome = "João Silva";
            usuario.Email = "joao.silva@example.com";
            usuario.Endereco = "Rua Exemplo, 123";
            usuario.NumeroEndereco = "123";
            usuario.Complemento = "Apto 45";
            usuario.Cep = "12345-678";
            usuario.NumeroTelefone = "(11) 91234-5678";
            usuario.Cpf = "123.456.789-10";

            using (var database = CreateDatabaseConnection())
            {
                var usuarioRepository = new UsuarioRepository(database);
                var command = new CreateUsuarioCommand(usuario, usuarioRepository);

                Usuario usuario_banco = usuarioRepository.GetUsuarioById(usuario.Id);

                // Act
                command.Execute();

                // Assert
                List<Usuario> usuarios = usuarioRepository.GetUsuarios();
                Assert.Contains(usuario_banco, usuarios);
            }
        }

        [Fact(DisplayName = "Testa a validade da atualização de um usuario")]
        public void AtualizaUsuario()
        {
            // Arrange
            var usuario = _usuarioFactory.CreateUsuario();
            usuario.Nome = "Teste";
            usuario.Email = "teste@example.com";
            usuario.Endereco = "Rua Teste";
            usuario.NumeroEndereco = "123";
            usuario.Complemento = "Apt 456";
            usuario.Cep = "12345-678";
            usuario.NumeroTelefone = "(11) 91234-5678";
            usuario.Cpf = "123.456.789-00";

            using (var database = CreateDatabaseConnection())
            {
                var usuarioRepository = new UsuarioRepository(database);
                var createCommand = new CreateUsuarioCommand(usuario, usuarioRepository);
                createCommand.Execute();

                // Act
                usuario.Nome = "Teste Atualizado";
                var updateCommand = new UpdateUsuarioCommand(usuario, usuarioRepository);
                updateCommand.Execute();

                // Assert
                var usuarios = usuarioRepository.GetUsuarios();
                Assert.Contains(usuario, usuarios);
                Assert.Equal("Teste Atualizado", usuarios.FirstOrDefault(u => u.Id == usuario.Id)?.Nome);
            }
        }

        [Fact(DisplayName = "Testa a validade da exclusão de um usuario")]
        public void ExcluiUsuario()
        {
            // Arrange
            var usuario = _usuarioFactory.CreateUsuario();
            usuario.Nome = "Teste";
            usuario.Email = "teste@example.com";
            usuario.Endereco = "Rua Teste";
            usuario.NumeroEndereco = "123";
            usuario.Complemento = "Apt 456";
            usuario.Cep = "12345-678";
            usuario.NumeroTelefone = "(11) 91234-5678";
            usuario.Cpf = "123.456.789-00";

            using (var database = CreateDatabaseConnection())
            {
                var usuarioRepository = new UsuarioRepository(database);
                var createCommand = new CreateUsuarioCommand(usuario, usuarioRepository);
                createCommand.Execute();

                // Act
                var deleteCommand = new DeleteUsuarioCommand(usuario, usuarioRepository);
                deleteCommand.Execute();

                // Assert
                var usuarios = usuarioRepository.GetUsuarios();
                Assert.DoesNotContain(usuario, usuarios);
            }
        }
    }
}
