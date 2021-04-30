

namespace Evaluacion.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }

        public bool StatusLog { get; set; }
    }
}
