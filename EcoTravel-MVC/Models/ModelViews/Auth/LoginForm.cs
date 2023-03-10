using EcoTravel_MVC.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Auth
{
    public class LoginForm
    {
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [MinLength(2)]
        [MaxLength(50)]
        [EmailAddress]
        [DisplayName("Email: *")]
        public string email { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [MinLength(8)]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe: *")]
        public string password { get; set; }
    }
}
