using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace API.Entities
{
    public class Pie
    {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id { get; set; }
      [Required]
      [MaxLength(50)]
      public string Name { get; set; }
      public int PieTypeId { get; set; }
      public int UserId { get; set; }
      public DateTime DateCreated { get; set; }
    }
}