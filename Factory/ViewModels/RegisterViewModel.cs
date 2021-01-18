using System.ComponentModel.DataAnnotations;

namespace Factory.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
  }
}