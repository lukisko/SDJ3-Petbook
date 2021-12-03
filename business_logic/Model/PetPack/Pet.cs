using System;
using System.Net.Mail;

namespace business_logic.Model
{
    public class Pet
    {
        public int id {get; set;}
        public string name {get; set;}
        public string type {get;set;}
        public string breed {get;set;}
        public string description {get;set;}
        public Status Status { get; set; }
        public DateTime BirthDate {get;set;}
        public City city {get;set;}
        public User user {get;set;}
    }
}