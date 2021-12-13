package DatabasePersistence;

import model.Pet;
import model.User;

import java.util.List;

public interface UserPersistence
{
  User loadUser(String email);
  List<User> loadAll();
  void save(User customer);
  void delete(User customer);
}
