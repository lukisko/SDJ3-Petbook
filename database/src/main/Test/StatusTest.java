import DatabasePersistence.*;
import model.*;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class StatusTest
{
  private StatusPersistence statusPersistence;
  private UserPersistence userPersistence;
  private PetPersistance petPersistance;

  private Status status1;
  private Status status2;
  private User user;
  private Pet pet;

  @BeforeEach void setUp()
  {
    statusPersistence = new StatusDatabase();
    userPersistence = new UserDatabase();
    petPersistance = new PetDatabase();
    user = userPersistence.loadUser("asd");
    pet = petPersistance.loadPet(1);
    status1 = new Status("test1",user,pet);
    status2 = new Status("test2",user,pet);
  }

  @Test void getStatusZero()
  {
    Status result = statusPersistence.loadStatus(1);

    assertNull(result);
  }
  @Test void getStatusOne()
  {
    int id = statusPersistence.save(status1);
    Status result = statusPersistence.loadStatus(id);
    statusPersistence.delete(statusPersistence.loadStatus(id));

    assertNotNull(result);
    assertEquals(status1.getName(),result.getName());
  }
  @Test void getStatusMany()
  {
    Status result = statusPersistence.loadStatus(1);

    assertNull(result);
  }
  @Test void getStatusBoundary()
  {
    Status result = statusPersistence.loadStatus(1);

    assertNull(result);
  }
  @Test void getStatusException()
  {
    Status result = statusPersistence.loadStatus(1);

    assertNull(result);
  }




  @Test
  void loadStatusOfPet()
  {

  }

  @Test
  void getAllStatuses()
  {

  }

  @Test
  void addStatus()
  {

  }

  @Test
  void removeStatus()
  {

  }
}

