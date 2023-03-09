using EcoTravel_MVC.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Client
{
    public class ClientCreateForm
    {

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Nom de famille: *")]
        [MinLength(2)]
        [MaxLength(50)]
        public string nom { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Prénom: *")]
        [MinLength(2)]
        [MaxLength(50)]
        public string prenom { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Adresse email: *")]
        [MinLength(2)]
        [MaxLength(250)]
        [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Pays: *")]
        [MinLength(2)]
        [MaxLength(50)]
        public string pays { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Telephone: *")]
        [MinLength(2)]
        [MaxLength(50)]
        [DataType(DataType.PhoneNumber)]
        public string telephone { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Mot de passe: *")]
        [MinLength(8)]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Confirmez le mot de passe: *")]
        [MinLength(8)]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [Compare(nameof(password))]
        public string confirmPassword { get; set; }
    }
}
