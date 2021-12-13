import model.Model;
import model.ModelManager;
import model.User;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class UserTest
{
  private Model model;
  private User user1;
  private User user2;
  private User user3;

  @BeforeEach
  void setUp()
  {
    model = new ModelManager();
    user1 = new User("test");
    user2 = new User("test1");
    user3 = new User("test2");
    model.addUser(user1);
  }
  @AfterEach
  void setDown(){
    if(model.getUser(user1.getEmail()) != null)
    {
      model.removeUser(model.getUser(user1.getEmail()));
    }
  }

  @Test
  void getUser(){
    User result = model.getUser(user1.getEmail());

    assertNotNull(result);
    assertEquals("test", result.getEmail());

  }
  @Test
  void getAllUsers(){
    model.addUser(user2);
    model.addUser(user3);
    List<User> result = model.getAllUsers();
    model.removeUser(model.getUser(user2.getEmail()));
    model.removeUser(model.getUser(user3.getEmail()));

    assertNotNull(result);
    assertTrue(2 < (long) result.size());
  }
  @Test
  void removeUser(){
    model.removeUser(model.getUser(user1.getEmail()));
    User result = model.getUser(user1.getEmail());

    assertNull(result);
  }
  @Test
  void addUser(){
    User result = model.getUser(user1.getEmail());

    assertNotNull(result);
    assertEquals("test", result.getEmail());
  }
}
