using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace turismo.ViewModel.Registro
{
    public class RegistroViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public String email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        public String contraseña {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Compare("contraseña")]
        public String repiteContraseña { get; set; }

        }
    }
   

