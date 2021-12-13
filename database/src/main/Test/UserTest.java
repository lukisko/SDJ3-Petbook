import DatabasePersistence.PetDatabase;
import DatabasePersistence.PetPersistance;
import DatabasePersistence.UserDatabase;
import DatabasePersistence.UserPersistence;
import model.*;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;

import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class UserTest
{
  private UserPersistence userPersistence;
  private User user1;
  private User user2;

  @BeforeEach
  void setUp()
  {
    userPersistence = new UserDatabase();
    user1 = new User("test1");
    user2 = new User("test2");

  }

  @Test
  void getUserZero(){

    User result = userPersistence.loadUser(user1.getEmail());

    assertNull(result);
  }
  @Test
  void getUserOne(){
    userPersistence.save(user1);
    User result = userPersistence.loadUser(user1.getEmail());
    userPersistence.delete(userPersistence.loadUser(user1.getEmail()));

    assertNotNull(result);
    assertEquals("test1", result.getEmail());
  }
  @Test
  void getUserMany(){
    userPersistence.save(user1);
    userPersistence.save(user2);
    User result1 = userPersistence.loadUser(user1.getEmail());
    User result2 = userPersistence.loadUser(user2.getEmail());
    userPersistence.delete(userPersistence.loadUser(user1.getEmail()));
    userPersistence.delete(userPersistence.loadUser(user2.getEmail()));

    assertNotNull(result1);
    assertNotNull(result2);
    assertEquals("test1", result1.getEmail());
    assertEquals("test2", result2.getEmail());
  }
  @Test
  void getUserBoundary(){

  }
  @Test
  void getUserException(){
    assertThrows(IllegalArgumentException.class,() -> userPersistence.loadUser(null));
  }



  @Test
  void getAllUsersZero(){
    List<User> userList = userPersistence.loadAll();

    userList.removeIf(
        user -> !user.getEmail().equals(user1.getEmail()) && !user.getEmail()
            .equals(user2.getEmail()));

    assertEquals(0, userList.size());
  }
  @Test
  void getAllUsersOne(){
    userPersistence.save(user1);
    List<User> userList = userPersistence.loadAll();
    userPersistence.delete(userPersistence.loadUser(user1.getEmail()));

    userList.removeIf(
        user -> !user.getEmail().equals(user1.getEmail()) && !user.getEmail()
            .equals(user2.getEmail()));

    assertNotNull(userList);
    assertEquals("test1", userList.get(0).getEmail());
    assertTrue(2 > userList.size());
  }
  @Test
  void getAllUsersMany(){
    userPersistence.save(user1);
    userPersistence.save(user2);
    List<User> userList = userPersistence.loadAll();
    userPersistence.delete(userPersistence.loadUser(user1.getEmail()));
    userPersistence.delete(userPersistence.loadUser(user2.getEmail()));

    userList.removeIf(
        user -> !user.getEmail().equals(user1.getEmail()) && !user.getEmail()
            .equals(user2.getEmail()));

    assertNotNull(userList);
    assertEquals("test1", userList.get(0).getEmail());
    assertTrue(1 < userList.size());
  }
  @Test
  void getAllUsersBoundary(){

  }
  @Test
  void getAllUsersException(){

  }




  @Test
  void addUserZero(){

    User result = userPersistence.loadUser(user1.getEmail());

    assertNull(result);
  }
  @Test
  void addUserOne(){
    userPersistence.save(user1);
    User result = userPersistence.loadUser(user1.getEmail());
    userPersistence.delete(userPersistence.loadUser(user1.getEmail()));

    assertNotNull(result);
    assertEquals("test1", result.getEmail());
  }
  @Test
  void addUserMany(){
    userPersistence.save(user1);
    userPersistence.save(user2);
    User result1 = userPersistence.loadUser(user1.getEmail());
    User result2 = userPersistence.loadUser(user2.getEmail());
    userPersistence.delete(userPersistence.loadUser(user1.getEmail()));
    userPersistence.delete(userPersistence.loadUser(user2.getEmail()));

    assertNotNull(result1);
    assertNotNull(result2);
    assertEquals("test1", result1.getEmail());
    assertEquals("test2", result2.getEmail());
  }
  @Test
  void addUserBoundary(){

  }
  @Test
  void addUserException(){
    assertThrows(IllegalArgumentException.class,() -> userPersistence.loadUser(null));
  }

}
