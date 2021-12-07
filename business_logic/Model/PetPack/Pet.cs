using System;
using System.Net.Mail;
using System.Collections.Generic;

namespace business_logic.Model
{
    public class Pet
    {
        public int id {get; set;}
        public string name {get; set;}
        public string type {get;set;}
        public string breed {get;set;}
        public string description {get;set;}
        public IList<Status> statuses { get; set; }
        public DateTime birthdate {get;set;}
        public City city {get;set;}
        public User user {get;set;}
        public char gender {get;set;}

        public static Pet copy(Pet pet){
            return new Pet(){
                name = pet.name,
                id = pet.id,
                type = pet.type,
                breed = pet.breed,
                description = pet.description,
                birthdate = pet.birthdate,
                city = pet.city,
                user = pet.user,
                gender = pet.gender,
                statuses = pet.statuses
            };
        }
    }
}