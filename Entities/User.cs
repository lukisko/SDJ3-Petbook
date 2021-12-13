using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        [Required] [EmailAddress] public string email { get; set; }
        [Required] public string name { get; set; }
         public string code { get; set; }

         public User copy(){
             return new User(){
                 email = this.email,
                 name = this.name
             };
         }
    }
}