using System;

namespace Entities
{
    public class MessageDatabase
    {
        public int id {get;set;}
        public Pet sender {get;set;}
        public Pet receiver {get;set;}
        public string message {get;set;}
        public DateTime datetime {get;set;}
    }
}