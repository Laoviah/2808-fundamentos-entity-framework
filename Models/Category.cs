using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] VARCHAR(80) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    [Table("Category")]
    public class Category{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public int Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "VARCHAR")]
        public string Slug { get; set; } ="";
    }
}