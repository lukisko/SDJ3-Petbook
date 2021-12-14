using Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace business_logic.Model.Mediator
{
    public class Tier2Message : ITier2Message
    {
        private ITier2Singleton tier2;

        public Tier2Message(ITier2Singleton tier2){
            this.tier2 = tier2;
        }

        public async Task<Message> getMessage(Message messg){
            Comunication<MessageDatabase> commClass = new Comunication<MessageDatabase>("message","Get",this.fromMessageToDatabase(messg));

            Comunication<MessageDatabase> theMessage = await tier2.requestServerAsync<Comunication<MessageDatabase>, Comunication<MessageDatabase>>(commClass);

            return this.fromDatabaseToMessage(theMessage.value);
        }

        public async Task<IList<Message>> getAllOfMessage(int receiverId, int senderId){
            Message messg = new Message(){ReceiverPetId = receiverId, SenderPetId = senderId};
            Comunication<MessageDatabase> commClass = new Comunication<MessageDatabase>("message","GetAllOf",this.fromMessageToDatabase(messg));

            Comunication<IList<MessageDatabase>> theMessageList = await tier2.requestServerAsync<Comunication<MessageDatabase>, Comunication<IList<MessageDatabase>>>(commClass);

            IList<Message> messages = new List<Message>();
            foreach (MessageDatabase msgData in theMessageList.value){
                messages.Add(this.fromDatabaseToMessage(msgData));
            }

            return messages;
        }

        public async Task<IList<Message>> getAllOfReceiverMessage(int receiverId){
            Message messg = new Message(){ReceiverPetId = receiverId};
            Comunication<MessageDatabase> commClass = new Comunication<MessageDatabase>("message","GetAllOfReceiver",this.fromMessageToDatabase(messg));

            Comunication<IList<MessageDatabase>> theMessageList = await tier2.requestServerAsync<Comunication<MessageDatabase>, Comunication<IList<MessageDatabase>>>(commClass);

            IList<Message> messages = new List<Message>();
            foreach (MessageDatabase msgData in theMessageList.value){
                messages.Add(this.fromDatabaseToMessage(msgData));
            }

            return messages;
        }

        public async Task<Message> addMessage(Message messg){
            Comunication<MessageDatabase> commClass = new Comunication<MessageDatabase>("message","Add",this.fromMessageToDatabase(messg));

            Comunication<MessageDatabase> theMessage = await tier2.requestServerAsync<Comunication<MessageDatabase>, Comunication<MessageDatabase>>(commClass);

            return this.fromDatabaseToMessage(theMessage.value);
        }

        public async Task<Message> removeMessage(Message messg){
            Comunication<MessageDatabase> commClass = new Comunication<MessageDatabase>("message","Remove",this.fromMessageToDatabase(messg));

            Comunication<string> theMessage = await tier2.requestServerAsync<Comunication<MessageDatabase>, Comunication<string>>(commClass);

            return messg;
        }

        private Message fromDatabaseToMessage(MessageDatabase msgData){
            return new Message(){
                ReceiverPetId = (msgData.receiver == null)? 0:msgData.receiver.id,
                SenderPetId = (msgData.sender == null)? 0:msgData.sender.id,
                MessageBody = msgData.message,
                DateTime = msgData.datetime
            };
        }

        private MessageDatabase fromMessageToDatabase(Message msg){
            return new MessageDatabase(){
                receiver = new Pet(){id = msg.ReceiverPetId},
                sender = new Pet(){id = msg.SenderPetId},
                message = msg.MessageBody,
                datetime = msg.DateTime
            };
        }
    }
}