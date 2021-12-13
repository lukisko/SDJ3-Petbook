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
        public Pet copy(){
            List<Status> status2 = new List<Status>();
            status2.AddRange(statuses);
            return new Pet(){
                imageUrl = this.imageUrl,
                id = id,
                name = name,
                type = type,
                breed = breed,
                gender = gender,
                description = description,
                statuses = status2,
                birthdate = new DateTime(birthdate.Year,birthdate.Month,birthdate.Day),
                city = new City(){
                    name = city.name,
                    country = new Country(){
                        name = city.country.name
                    }
                },
                user = user.copy()
            };
            

        }
    }
}