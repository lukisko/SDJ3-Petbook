package DatabasePersistence;

import model.Pet;
import model.User;

import java.util.List;

public interface UserPersistence
{
  /**
   * loads user from database
   * @param email email of the user
   * @return user object
   */
  User loadUser(String email);
  /**
   * loads all users from database
   * @return list of user objects
   */
  List<User> loadAll();
  /**
   * saves user to database
   * @param user customer to be saved
   * @throws IllegalArgumentException if user is null
   */
  void save(User user);
  /**
   * delete user from database
   * @param user user to be deleted
   * @throws IllegalArgumentException if user is null or not existing in database
   */
  void delete(User user);
}
