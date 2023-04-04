using System.ComponentModel.DataAnnotations;

namespace EstoriasMalucas.Models
{
    public class Formulario
    {

        [Required(ErrorMessage = "Campo Obrigatório")]
        public uint Idade { get; set; }

        public string UsuarioName { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amigo1 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amigo3 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amigo5 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amigo7 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amigo9 { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amiga2 { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amiga4 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amiga6 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amiga8 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Amiga10 { get; set; }

    }
}
