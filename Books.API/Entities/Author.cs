using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.API.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }
    }
}