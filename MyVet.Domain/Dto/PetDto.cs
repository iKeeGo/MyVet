
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVet.Domain.Dto
{
    public class PetDto
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Pet name is required!")]
        [Display(Name = "Date of birth")]
        public DateTime DateBorns { get; set; }

        [Required(ErrorMessage = "Sex is require")]
        public int IdSex { get; set; }

        [Required(ErrorMessage = "Pet type is required")]
        public int IdTypePet { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }


        public string Edad { get; set; }
        public string Sexo { get; set; }
        public string TypePet { get; set; }
        public int IdUser { get; set; }
    }
}