using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class UpdateFilmeDto // Dto => Data Transfer Object
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Titulo { get; set; }
        [StringLength(30, ErrorMessage = "{0} - Máximo de 30 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, 280, ErrorMessage = "{0} de 1 até 280")]
        public int Duracao { get; set; }
    }
}
