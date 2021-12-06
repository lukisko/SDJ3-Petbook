using System.ComponentModel.DataAnnotations;

namespace ClientApp.Model
{
    public class User
    {
        [Required] [EmailAddress] public string email { get; set; }
        [Required] public string name { get; set; }
        [Required] public string code { get; set; }
    }
}