using System;
using System.Collections.Generic;
using System.Net.Mail;


namespace Entities
{
    public class Pet
    {
        public string imageUrl { get; set; }
        public int id {get; set;}
        public string name {get; set;}
        public string type {get;set;}
        public string breed {get;set;}
        public char gender {get;set;}
        public string description {get;set;}
        public IList<Status> statuses { get; set; }
        public DateTime birthdate {get;set;}
        public City city {get;set;}
        public User user {get;set;}
        
    }
}