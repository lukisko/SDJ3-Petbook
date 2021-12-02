import model.*;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class PetTest
{
  private Model model;
  private User user;
  private Country country;
  private City city;
  private Pet pet;
  private Pet pet1;
  private Pet pet2;

  @BeforeEach void setUp()
  {
    model = new ModelManager();
    user = new User("test");
    country = new Country("test");
    city = new City("test");
    city.setCountry(country);
    pet = new Pet("test",city);
    pet1 = new Pet("test1",city);
    pet2 = new Pet("test2",city);

    model.addUser(user);
    model.addCountry(country);
    model.addCity(country.getName(),city);
    model.addPet(user.getEmail(),pet);
  }
  @AfterEach
  void setDown(){
    model.removePet(model.getPet(getId(0)));
    model.removeCity(model.getCity(city.getName()));
    model.removeCountry(model.getCountry(country.getName()));
    model.removeUser(model.getUser(user.getEmail()));
  }

  @Test void getPet()
  {
    Pet result = model.getPet(getId(0));

    assertNotNull(result);
    assertEquals("test", result.getName());

  }
  @Test void addPet()
  {
    model.addPet(user.getEmail(), pet1);
    Pet result = model.getPet(getId(1));
    model.removePet(model.getPet(getId(1)));

    assertNotNull(result);
    assertEquals("test1", result.getName());
  }
  @Test void removePet()
  {
    int id = getId(0);

    assertNotNull(model.getPet(id));

    model.removePet(model.getPet(getId(0)));

    assertNull(model.getPet(id));

    model.addPet(user.getEmail(), pet);
  }
  @Test void getAllPets()
  {

    model.addPet(user.getEmail(), pet1);
    model.addPet(user.getEmail(), pet2);
    List<Pet> result = model.getAllPets();
    model.removePet(model.getPet(getId(2)));
    model.removePet(model.getPet(getId(1)));

    assertNotNull(result);
    assertTrue(2 < (long) result.size());
    assertEquals(getId(0), result.get(0).getId());


  }
  @Test void getAllPetsOfUser()
  {
    model.addPet(user.getEmail(), pet1);
    model.addPet(user.getEmail(), pet2);
    List<Pet> result = model.getPetList(user.getEmail());
    model.removePet(model.getPet(getId(2)));
    model.removePet(model.getPet(getId(1)));

    assertNotNull(result);
    assertTrue(2 < (long) result.size());
    assertEquals(user.getEmail(), result.get(1).getUser().getEmail());

  }









  private int getId(int position)
  {
    List<Pet> pets = model.getPetList(user.getEmail());
    return pets.get(position).getId();
  }
}
