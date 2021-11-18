package DatabasePersistence;

import model.User;

import java.util.List;

public interface UserPersistence
{
  User loadUser(String email);
  List<User> loadAll();
  void save(User customer);
}
