
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models {
    public class Filme {

        public int Id { get; set; }

        [Required(ErrorMessage ="O Título do Filme é Obrigatório")]        
        public string Titulo { get; set; }        

        [Required(ErrorMessage = "O Genero do Filme é Obrigatório")]
        [MaxLength(50, ErrorMessage = "Tamanho Maximo é de 50")]
        public string Genero { get; set; }
        
        [Required(ErrorMessage = "A duração do Filme é Obrigatório")]
        [Range(70, 600, ErrorMessage = "Duração de Filme devem estar dentre 70 a 600 Minutos!")]
        public int Duracao { get; set; }

    }
}
