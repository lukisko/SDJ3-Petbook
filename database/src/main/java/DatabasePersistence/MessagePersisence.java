package DatabasePersistence;

import model.Message;
import model.Pet;

import java.util.List;

public interface MessagePersisence
{
  Message loadMessage(int id);
  List<Message> LoadMessagesOfPets(int id1, int id2);
  int save(Message message);
  void delete(Message message);
}
