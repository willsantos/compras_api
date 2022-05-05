using System.ComponentModel.DataAnnotations;

namespace compras_api.Models
{
  public class Item
  {
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }

  }
}