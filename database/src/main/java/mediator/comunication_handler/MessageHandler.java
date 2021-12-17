package mediator.comunication_handler;

import DatabasePersistence.MessageDatabase;
import DatabasePersistence.MessagePersisence;
import DatabasePersistence.PetDatabase;
import DatabasePersistence.PetPersistance;
import com.google.gson.Gson;
import mediator.Comunication;
import model.Message;
import model.Pet;
import model.User;

import java.util.List;

public class MessageHandler
{
  private String response;
  private Gson gson;
  private MessagePersisence messagePersisence;

  public MessageHandler()
  {
    gson = new Gson();
    messagePersisence = new MessageDatabase();
  }

  private void findMethod(String method, Message value)
  {
    switch (method)
    {
      case "Get":
        response = get(value);
        break;
      case "GetAllOf":
        response = getAllOf(value);
        break;
      case "GetAllOfReceiver":
        response = getAllOfReceiver(value);
        break;
      case "GetAllOfSender":
        response = getAllOfSender(value);
        break;
      case "Add":
        response = add(value);
        break;
      case "Remove":
        response = remove(value);
        break;
    }
  }

  private String get(Message value)
  {
    try
    {
      return gson.toJson(new Comunication<Message>("message", "Get",
          messagePersisence.loadMessage(value.getId())));
    }
    catch (Exception e)
    {
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }

  private String getAllOf(Message value)
  {
    try
    {
      return gson.toJson(new Comunication<List<Message>>("message", "GetAllOf",
          messagePersisence.LoadMessagesOfPets(value.getReceiver().getId(),
              value.getSender().getId())));
    }
    catch (Exception e)
    {
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAllOfReceiver(Message value)
  {
    try
    {
      return gson.toJson(new Comunication<List<Message>>("message", "GetAllOfReceiver",
          messagePersisence.LoadMessagesOfReceiver(value.getReceiver().getId())));
    }
    catch (Exception e)
    {
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAllOfSender(Message value)
  {
    try
    {
      return gson.toJson(new Comunication<List<Message>>("message", "GetAllOfSender",
          messagePersisence.LoadMessagesOfSender(value.getSender().getId())));
    }
    catch (Exception e)
    {
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }

  private String add(Message value)
  {
    try
    {
      int id = messagePersisence.save(value);
      return gson.toJson(new Comunication<Message>("message", "Add",
          messagePersisence.loadMessage(id)));
    }
    catch (Exception e)
    {
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }

  public String remove(Message value)
  {
    try
    {
      messagePersisence.delete(messagePersisence.loadMessage(value.getId()));
      return gson.toJson(new Comunication<String>("pet", "Remove", "OK"));
    }
    catch (Exception e)
    {
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }

  public String getResponse(String method, Message value)
  {
    findMethod(method, value);
    return response;
  }
}
