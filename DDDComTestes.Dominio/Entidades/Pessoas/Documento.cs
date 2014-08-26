namespace DDDComTestes.Dominio.Entidades.Pessoas
{
    public class Documento : IEntidade
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public TipoDocumento Tipo { get; set; }
    }
}