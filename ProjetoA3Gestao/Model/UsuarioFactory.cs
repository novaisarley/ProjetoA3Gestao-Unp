namespace ProjetoA3Gestao.Model
{
    public abstract class UsuarioFactory
    {
        public abstract Usuario CreateUsuario();
    }

    public class ConcreteUsuarioFactory : UsuarioFactory
    {
        private static int _idCounter = 1;

        public override Usuario CreateUsuario()
        {
            return new Usuario { Id = _idCounter++ };
        }
    }
}