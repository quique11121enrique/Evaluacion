

namespace Evaluacion.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        public int Id { get; set; }
        [MaxLength(21)]

        public string Name { get; set; }
        [Required,EmailAddress]
        public string Address { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        public string Nickname { get; set; }
        [Required,MinLength(9)]
        public string Password { get; set; }
        [Required]
        public bool StatusLog { get; set; }
    }
}
