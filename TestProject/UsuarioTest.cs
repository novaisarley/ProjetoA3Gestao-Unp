/*using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Data;
using ProjetoA3Gestao.Model;
using System.Drawing.Printing;
using Xunit;

namespace TestProject
{
    public class UsuarioTest
    {
        [Fact(DisplayName = "Testa a validade da criação de um usuario")]
        public void CriaUsuario()
        {
            // Arrange: Preparar os dados necessários para o teste
            var usuario = new Usuario
            {
                Id = 1,
                Nome = "João Silva",
                Email = "joao.silva@example.com",
                Endereco = "Rua Exemplo, 123",
                NumeroEndereco = "123",
                Complemento = "Apto 45",
                Cep = "12345-678",
                NumeroTelefone = "(11) 91234-5678",
                Cpf = "123.456.789-10"
            };

            var database = new Database();
            var command = new CreateUsuarioCommand(usuario, database.UsuarioRepository); // Passando o UsuarioRepository do Database

            // Act: Executar a ação a ser testada
            command.Execute();
            // Assert: Verificar se o resultado é o esperado
            var usuarios = database.UsuarioRepository.GetUsuarios();
            Assert.Contains(usuario, usuarios);
        }

        [Fact(DisplayName = "Testa a validade da atualização de um usuario")]
        public void AtualizaUsuario()
        {
            // Arrange
            var usuario = new Usuario
            {
                Nome = "Teste",
                Email = "teste@example.com",
                Endereco = "Rua Teste",
                NumeroEndereco = "123",
                Complemento = "Apt 456",
                Cep = "12345-678",
                NumeroTelefone = "(11) 91234-5678",
                Cpf = "123.456.789-00"
            };

            var database = new Database();
            var createCommand = new CreateUsuarioCommand(usuario, database.UsuarioRepository);
            createCommand.Execute();

            // Act
            usuario.Nome = "Teste Atualizado";
            database.UsuarioRepository.UpdateUsuario(usuario);
            var usuarios = database.UsuarioRepository.GetUsuarios();

            // Assert
            Assert.Contains(usuario, usuarios);
            Assert.Equal("Teste Atualizado", usuarios.FirstOrDefault(u => u.Id == usuario.Id)?.Nome);
        }

        [Fact(DisplayName = "Testa a validade da exclusão de um usuario")]
        public void ExcluiUsuario()
        {
            // Arrange
            var usuario = new Usuario
            {
                Nome = "Teste",
                Email = "teste@example.com",
                Endereco = "Rua Teste",
                NumeroEndereco = "123",
                Complemento = "Apt 456",
                Cep = "12345-678",
                NumeroTelefone = "(11) 91234-5678",
                Cpf = "123.456.789-00"
            };

            var database = new Database();
            var createCommand = new CreateUsuarioCommand(usuario, database.UsuarioRepository);
            createCommand.Execute();

            // Act
            database.UsuarioRepository.RemoveUsuario(usuario);
            var usuarios = database.UsuarioRepository.GetUsuarios();

            // Assert
            Assert.DoesNotContain(usuario, usuarios);
        }
    }
}
*/