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
    pet = petPersistance.loadPet(10000);
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
    int id1 = statusPersistence.save(status1);
    int id2 = statusPersistence.save(status2);
    Status result1 = statusPersistence.loadStatus(id1);
    Status result2 = statusPersistence.loadStatus(id2);
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    statusPersistence.delete(statusPersistence.loadStatus(id2));

    assertNotNull(result1);
    assertEquals(status1.getName(),result1.getName());
    assertNotNull(result2);
    assertEquals(status2.getName(),result2.getName());
  }
  @Test void getStatusBoundary()
  {

  }
  @Test void getStatusException()
  {

  }




  @Test
  void loadStatusOfPetZero()
  {
    List<Status> result = statusPersistence.loadStatusOfPet(10000);

    assertEquals(0,result.size());
  }
  @Test
  void loadStatusOfPetOne()
  {
    int id1 = statusPersistence.save(status1);
    List<Status> result = statusPersistence.loadStatusOfPet(status1.getPet().getId());
    statusPersistence.delete(statusPersistence.loadStatus(id1));

    assertEquals(1,result.size());
    assertEquals(status1.getName(), result.get(0).getName());
  }
  @Test
  void loadStatusOfPetMany()
  {
    int id1 = statusPersistence.save(status1);
    int id2 = statusPersistence.save(status2);
    List<Status> result = statusPersistence.loadStatusOfPet(status1.getPet().getId());
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    statusPersistence.delete(statusPersistence.loadStatus(id2));

    assertEquals(2,result.size());
    assertEquals(status1.getName(), result.get(0).getName());
    assertEquals(status2.getName(), result.get(1).getName());
  }
  @Test
  void loadStatusOfPetBoundary()
  {

  }
  @Test
  void loadStatusOfPetException()
  {

  }



  @Test
  void getAllStatusesZero()
  {
    List<Status> result = statusPersistence.loadAll();
    result.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(0,result.size());
  }
  @Test
  void getAllStatusesOne()
  {
    int id1 = statusPersistence.save(status1);
    List<Status> result = statusPersistence.loadAll();
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    result.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(1,result.size());
  }
  @Test
  void getAllStatusesMany()
  {
    int id1 = statusPersistence.save(status1);
    int id2 = statusPersistence.save(status2);
    List<Status> result = statusPersistence.loadAll();
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    statusPersistence.delete(statusPersistence.loadStatus(id2));
    result.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(2,result.size());
  }
  @Test
  void getAllStatusesBoundary()
  {

  }
  @Test
  void getAllStatusesException()
  {

  }




  @Test
  void getAllOfZero()
  {
    List<Status> result = statusPersistence.getAllOf("test1");

    assertEquals(0, result.size());
  }
  @Test
  void getAllOfOne()
  {
    int id1 = statusPersistence.save(status1);
    List<Status> result = statusPersistence.getAllOf("test1");
    statusPersistence.delete(statusPersistence.loadStatus(id1));

    assertEquals(1, result.size());
    assertEquals(status1.getName(), result.get(0).getName());
  }
  @Test
  void getAllOfMany()
  {
    int id1 = statusPersistence.save(status1);
    int id2 = statusPersistence.save(status1);
    List<Status> result = statusPersistence.getAllOf("test1");
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    statusPersistence.delete(statusPersistence.loadStatus(id2));

    assertEquals(2, result.size());
    assertEquals(status1.getName(), result.get(0).getName());
    assertEquals(status1.getName(), result.get(1).getName());
  }
  @Test
  void getAllOfBoundary()
  {

  }
  @Test
  void getAllOfException()
  {
    assertThrows(IllegalArgumentException.class,() -> statusPersistence.getAllOf(null));
  }


  @Test
  void addStatusZero()
  {
    List<Status> result = statusPersistence.loadAll();
    result.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(0,result.size());
  }
  @Test
  void addStatusOne()
  {
    int id1 = statusPersistence.save(status1);
    List<Status> result = statusPersistence.loadAll();
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    result.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(1,result.size());
  }
  @Test
  void addStatusMany()
  {
    int id1 = statusPersistence.save(status1);
    int id2 = statusPersistence.save(status2);
    List<Status> result = statusPersistence.loadAll();
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    statusPersistence.delete(statusPersistence.loadStatus(id2));
    result.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(2,result.size());
  }
  @Test
  void addStatusBoundary()
  {

  }
  @Test
  void addStatusException()
  {
    assertThrows(IllegalArgumentException.class,() -> statusPersistence.save(null));
  }




  @Test
  void removeStatusZero()
  {

  }
  @Test
  void removeStatusOne()
  {
    int id1 = statusPersistence.save(status1);
    List<Status> before = statusPersistence.loadAll();
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    List<Status> after = statusPersistence.loadAll();
    before.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    after.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(1,before.size());
    assertEquals(0,after.size());
  }
  @Test
  void removeStatusMany()
  {
    int id1 = statusPersistence.save(status1);
    int id2 = statusPersistence.save(status1);
    List<Status> before = statusPersistence.loadAll();
    statusPersistence.delete(statusPersistence.loadStatus(id1));
    statusPersistence.delete(statusPersistence.loadStatus(id2));
    List<Status> after = statusPersistence.loadAll();
    before.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    after.removeIf(
        country -> !country.getName().equals(status1.getName()) && !country.getName()
            .equals(status2.getName()));
    assertEquals(2,before.size());
    assertEquals(0,after.size());
  }
  @Test
  void removeStatusBoundary()
  {

  }
  @Test
  void removeStatusException()
  {
    assertThrows(IllegalArgumentException.class,() -> statusPersistence.delete(null));
    assertThrows(IllegalArgumentException.class,() -> statusPersistence.delete(status1));
  }



  @Test
  void updateZero()
  {

  }
  @Test
  void updateOne()
  {
    int id = statusPersistence.save(status1);
    assertEquals(status1.getName(),statusPersistence.loadStatus(id).getName());
    status1 = statusPersistence.loadStatus(id);
    status1.setName(status2.getName());
    statusPersistence.update(status1);
    Status result = statusPersistence.loadStatus(id);
    statusPersistence.delete(result);
    assertEquals(status2.getName(),result.getName());
  }
  @Test
  void updateMany()
  {
    int id1 = statusPersistence.save(status1);
    int id2 = statusPersistence.save(status2);
    assertEquals(status1.getName(),statusPersistence.loadStatus(id1).getName());
    assertEquals(status2.getName(),statusPersistence.loadStatus(id2).getName());
    status1 = statusPersistence.loadStatus(id1);
    status1.setName(status2.getName());
    statusPersistence.update(status1);
    status2 = statusPersistence.loadStatus(id2);
    status2.setName(status1.getName());
    statusPersistence.update(status2);
    Status result1 = statusPersistence.loadStatus(id1);
    statusPersistence.delete(result1);
    Status result2 = statusPersistence.loadStatus(id2);
    statusPersistence.delete(result2);
    assertEquals(status2.getName(),result1.getName());
    assertEquals(status1.getName(),result2.getName());
  }
  @Test
  void updateBoundary()
  {

  }
  @Test
  void updateException()
  {
    assertThrows(IllegalArgumentException.class,() -> statusPersistence.delete(null));
  }
}

