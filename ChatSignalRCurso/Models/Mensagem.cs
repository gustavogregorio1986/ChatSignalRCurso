namespace ChatSignalRCurso.Models
{
    public class Mensagem
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Conteudo { get; set; }

        public string Sala { get; set; }

        public DateTime DataEnvio { get; set; }
    }
}
