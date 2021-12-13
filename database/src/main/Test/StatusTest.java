import model.*;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class StatusTest
{
  private Model model;
  private User user;
  private Country country;
  private City city;
  private Pet pet;
  private Status status;
  private Status status2;
  private int petId;
  private int statusId;
  private int statusId2;

  @BeforeEach void setUp()
  {
    model = new ModelManager();
    country = new Country("test");
    city = new City("test");
    city.setCountry(country);
    user = new User("test");
    pet = new Pet("test", city);
    pet.setUser(user);
    status = new Status();
    status.setPet(pet);
    status.setName("test");
    status.setUser(user);
    status2 = new Status();
    status2.setPet(pet);

    model.addUser(user);
    model.addCountry(country);
    model.addCity(city);
    petId = model.addPet(pet);
    statusId = model.addStatus(status);
  }

  @AfterEach void setDown()
  {
    model.removeStatus(model.getStatus(statusId));
    model.removePet(model.getPet(petId));
    model.removeCity(model.getCity(city.getName()));
    model.removeCountry(model.getCountry(country.getName()));
    model.removeUser(model.getUser(user.getEmail()));
  }

  @Test void getStatus()
  {
    Status result = model.getStatus(statusId);

    assertNotNull(result);
    assertEquals("test", result.getName());
  }

  @Test
  void loadStatusOfPet()
  {
    System.out.println("STATUS2 :   " + status2);
    statusId2 = model.addStatus(status2);
    List<Status> result = model.getStatusList(petId);
    model.removeStatus(model.getStatus(statusId2));

    assertNotNull(result);
    assertTrue(1 < result.size());
    assertEquals("test", result.get(0).getPet().getName());
    assertEquals("test", result.get(1).getPet().getName());
  }

  @Test
  void getAllStatuses()
  {
    statusId2 = model.addStatus(status2);
    List<Status> result = model.getStatusList(petId);
    model.removeStatus(model.getStatus(statusId2));

    assertNotNull(result);
    assertTrue(1 < result.size());
  }

  @Test
  void addStatus()
  {

    List<Status> result = model.getStatusList(petId);
    statusId2 = model.addStatus(status2);

    assertTrue(model.getAllStatuses().size() > result.size());

    model.removeStatus(model.getStatus(statusId2));


    assertTrue(0 < result.size());
  }

  @Test
  void removeStatus()
  {
    statusId2 = model.addStatus(status2);
    List<Status> result = model.getStatusList(petId);
    model.removeStatus(model.getStatus(statusId2));

    assertTrue(model.getAllStatuses().size() < result.size());
    assertNull(model.getStatus(statusId2));
  }
}

