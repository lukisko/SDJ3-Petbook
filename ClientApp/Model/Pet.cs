using System;
using System.Net.Mail;


namespace ClientApp.Model
{
    public class Pet
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string breed { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public DateTime Birthdate { get; set; }
        public char gender {get;set;}
        public City city { get; set; }
        public User user { get; set; }
    }
}