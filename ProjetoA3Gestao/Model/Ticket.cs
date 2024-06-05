using SQLite;

namespace ProjetoA3Gestao.Model
{
    public class Ticket
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public int UsuarioId { get; set; } // Adiciona esta linha
        [Ignore]
        public Usuario Usuario { get; set; }
    }
}
