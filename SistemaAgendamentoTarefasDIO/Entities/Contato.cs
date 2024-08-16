namespace SistemaAgendamentoTarefasDIO.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;    
        public bool Ativo { get; set; }
    }
}
