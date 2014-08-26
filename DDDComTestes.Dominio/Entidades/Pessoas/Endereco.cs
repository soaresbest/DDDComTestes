namespace DDDComTestes.Dominio.Entidades.Pessoas
{
    public class Endereco : IEntidade
    {
        public int ID { get; set; }
        public string Logradouro { get; set; }
        public TipoEndereco Tipo { get; set; }
    }
}