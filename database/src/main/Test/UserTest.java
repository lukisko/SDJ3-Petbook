import com.sun.istack.NotNull;
import model.Model;
import model.ModelManager;
import model.User;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class UserTest
{
  private Model model;

  @BeforeEach
  void setUp()
  {
    model = new ModelManager();
  }

  @Test
  void getUser(){
    User result = model.getUser("asd");

    assertNotNull(result);
    assertEquals("asd", result.getEmail());

  }
  @Test
  void getAllUsers(){
    List<User> result = model.getAllUsers();

    assertNotNull(result);
    assertTrue(5 < result.stream().count());
    assertTrue(result.contains(model.getUser("asd")));
  }
  @Test
  void removeUser(){
    User user = new User();
    user.setEmail("test");
    model.addUser(user);
    model.removeUser(user);
    User result = model.getUser(user.getEmail());

    assertNull(result);
  }
  @Test
  void addUser(){
    User user = new User();
    user.setEmail("test");
    model.addUser(user);
    User result = model.getUser("test");

    assertNotNull(result);
    assertEquals("test", result.getEmail());

    model.removeUser(result);
  }
}
