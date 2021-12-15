package DatabasePersistence;

import model.Message;
import model.Pet;

import java.util.List;

public interface MessagePersisence
{
  /**
   * loads message from database
   * @param id id of the message to load
   * @return message object from database
   */
  Message loadMessage(int id);
  /**
   * loads messages between two pets
   * @param id1 id of receiver
   * @param id2 id of sender
   * @return list of messages from database
   */
  List<Message> LoadMessagesOfPets(int id1, int id2);
  /**
   * loads received messages of specific pet
   * @param id2 id of receiver pet
   * @return list of messages from database
   */
  List<Message> LoadMessagesOfReceiver( int id2);
  /**
   * loads senders messages of specific pet
   * @param id1 id of sender pet
   * @return list of messages from database
   */
  List<Message> LoadMessagesOfSender( int id1);
  /**
   * saves message to database
   * @param message message object to be saved
   * @return id of saved message
   * @throws IllegalArgumentException if country is null
   */
  int save(Message message);
  /**
   * deletes message from database
   * @param message message object to be deleted from database
   * @throws IllegalArgumentException if message is null or is not existing inside of database
   */
  void delete(Message message);
}
