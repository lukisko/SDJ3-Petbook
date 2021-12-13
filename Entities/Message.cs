using System;

namespace Entities
{
    public class Message
    {
        
        public int SenderPetId { get; set; }
        public int ReceiverPetId { get; set; }
        public string MessageBody { get; set; }
        public DateTime DateTime { get; set; }
    }
}