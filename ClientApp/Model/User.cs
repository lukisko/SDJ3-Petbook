using System.ComponentModel.DataAnnotations;

namespace business_logic.Model
{
    public class User
    {
        [Required] [EmailAddress] public string email { get; set; }
        [Required] public string name { get; set; }
    }
}