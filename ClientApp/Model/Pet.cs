using System;
using System.Net.Mail;


namespace ClientApp.Model
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Birthdate { get; set; }
        public City City { get; set; }
        public User user { get; set; }
    }
}