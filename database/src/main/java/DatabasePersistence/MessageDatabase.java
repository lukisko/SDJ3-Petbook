package DatabasePersistence;

import model.Message;
import model.Pet;

import javax.persistence.Query;
import java.util.List;

public class MessageDatabase implements MessagePersisence
{
  private Database database;

  public MessageDatabase(){
    database = Database.getInstance(); //TODO add this to target
  }

  @Override public Message loadMessage(int id)
  {
    database.beginSession();
    Message message = database.getSession().get(Message.class,id);
    if(message != null)
    {
      message.clear();
    }
    return message;
  }

  @Override public List<Message> LoadMessagesOfPets(int id1, int id2)
  {
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM message c WHERE receiver_id = :receiver + sender_id = :sender");
    query.setParameter("receiver",id1);
    query.setParameter("sender",id2);
    List<Message> messageList = query.getResultList();
    if(messageList != null){
      messageList.forEach(Message::clear);
    }
    return messageList;
  }

  @Override public List<Message> LoadMessagesOfReceiver(int id2)
  {
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM message c WHERE receiver_id = :receiver");
    query.setParameter("receiver",id2);
    List<Message> messageList = query.getResultList();
    if(messageList != null){
      messageList.forEach(Message::clear);
    }
    return messageList;
  }

  @Override public int save(Message message)
  {
    database.beginSession();
    database.getSession().save(message);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return message.getId();
  }

  @Override public void delete(Message message)
  {
    database.beginSession();
    database.getSession().delete(message);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
