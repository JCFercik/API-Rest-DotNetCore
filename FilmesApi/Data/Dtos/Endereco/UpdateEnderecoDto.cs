namespace FilmesApi.Data.Dtos.Endereco
{
    public class UpdateEnderecoDto
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
