import model.*;
import org.checkerframework.checker.units.qual.C;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class PetTest
{
  private Model model;
  private User testUser;
  private City city;
  private Pet pet;

  @BeforeEach void setUp()
  {
    model = new ModelManager();
    testUser = new User();
    testUser.setEmail("test");
    city = new City();
    city.setName("AA");
    pet = new Pet();
    pet.setCity(city);
    pet.setName("test");

  }
  @Test void getPet()
  {
    Pet result = model.getPet(63);

    assertNotNull(result);
    assertEquals("string", result.getName());
    System.out.println(result);
  }
  @Test void addPet()
  {
    testUser = createUser();
    model.addPet(testUser.getEmail(), pet);
    Pet result = model.getPet(getId());

    assertNotNull(result);
    assertEquals("test", result.getName());

    model.removePet(result);
    removeUser();
  }
  @Test void removePet()
  {
    testUser = createUser();
    model.addPet(testUser.getEmail(), pet);
    List<Pet> result = model.getPetList(testUser.getEmail());

    assertEquals(1,result.size());
    assertEquals("test", result.get(0).getName());

    model.removePet(result.get(0));
    result = model.getPetList(testUser.getEmail());
    removeUser();

    assertEquals(0,result.size());
  }
  @Test void getAllPets()
  {
    List<Pet> result = model.getAllPets();

    assertNotNull(result);
    assertTrue(5 < result.stream().count());
    assertEquals(64, result.get(3).getId());


  }
  @Test void getAllPetsOfUser()
  {
    List<Pet> result = model.getPetList("blabla");

    assertNotNull(result);
    assertTrue(1 < result.stream().count());
    assertEquals(62, result.get(1).getId());

  }





  private User createUser()
  {
    model.addUser(testUser);
    return model.getUser(testUser.getEmail());
  }

  private void removeUser()
  {
    model.removeUser(testUser);
  }

  private int getId()
  {
    List<Pet> pets = model.getPetList(testUser.getEmail());
    System.out.println(pets);
    return pets.get(0).getId();
  }
}
