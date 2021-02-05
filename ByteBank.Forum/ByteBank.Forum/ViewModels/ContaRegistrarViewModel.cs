using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Forum.ViewModels
{
    public class ContaRegistrarViewModel
    {
        //Definir os atributos que o user vai preencher no formulario
        //Esses atributos são obrigatorios, para indicar isso: inserir o atributo [Required]
        [Required]
        public string UserName { get; set; }
        [Required]
        [Display(Name ="Nome Completo")]
        public string NomeCompleto { get; set; }
        [Required] 
        [EmailAddress]//Indica para o ASP .Net que este é um campo de E-mail
        public string Email { get; set; }
        [Required] 
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}
